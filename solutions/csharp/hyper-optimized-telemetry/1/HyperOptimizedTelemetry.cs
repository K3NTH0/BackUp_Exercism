public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        byte[] bytes = new byte[8];
        int bytesCount = FindTheGoodType(reading);
        bytes = GetBytesForType(reading, bytesCount);
        bool isSigned = IsSignedType(reading, bytesCount);
        
        if (isSigned)
        {
            buffer[0] = (byte)(256 - bytesCount);
        }
        else
        {
            buffer[0] = (byte)bytesCount ;
        }

        for (int i = 0; i < bytesCount; i++)
        {
            buffer[i+1] = bytes[i];
        }
        
        return buffer;
    }

    private static bool IsSignedType(long reading, int bytesCount)
    {
        
        if (bytesCount == 2 && reading >= 0) return false; // ushort
        if (bytesCount == 4 && reading > int.MaxValue) return false; // uint
        
        return true;
    }

    private static int FindTheGoodType(long reading)
    {
        return reading switch
        {
            >= 4_294_967_296 and <= 9_223_372_036_854_775_807 => 8, // long
            >= 2_147_483_648 and <= 4_294_967_295             => 4, // uint
            >= 65_536        and <= 2_147_483_647             => 4, // int
            >= 0             and <= 65_535                    => 2, // ushort
            >= -32_768       and <= -1                        => 2, // short
            >= -2_147_483_648and <= -32_769                   => 4, // int
            _                                                 => 8  // long
        };
    }
    
    private static byte[] GetBytesForType(long reading, int bytesCount)
    {
        return (bytesCount, reading < 0) switch
        {
            (2, false) => BitConverter.GetBytes((ushort)reading),
            (2, true) => BitConverter.GetBytes((short)reading),
            (4, false) when reading > int.MaxValue => BitConverter.GetBytes((uint)reading),
            (4, _) => BitConverter.GetBytes((int)reading),
            _ => BitConverter.GetBytes(reading)
        };
    }
    
    public static long FromBuffer(byte[] buffer)
    {
        return buffer[0] switch
        {
            // Types non signés
            2 => BitConverter.ToUInt16(buffer, 1),
            4 => BitConverter.ToUInt32(buffer, 1),

            // Types signés
            254 => BitConverter.ToInt16(buffer, 1), // 256 - 2
            252 => BitConverter.ToInt32(buffer, 1), // 256 - 4
            248 => BitConverter.ToInt64(buffer, 1), // 256 - 8
            
            _ => 0
        };
    }
}

static class Badge
{
    public static string Print(int? id, string name, string? department) => (id == null && department != null)? $"{name} - {department.ToUpper()}" : (department == null && id != null)? $"[{id}] - {name} - OWNER" : (id == null && department == null)? $"{name} - OWNER" : $"[{id}] - {name} - {department.ToUpper()}";
    
}

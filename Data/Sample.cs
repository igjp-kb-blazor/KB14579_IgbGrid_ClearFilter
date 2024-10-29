namespace KB14579_IgbGrid_ClearFilter.Data;

public class Sample
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? JobTitle { get; set; }
        public string? Location { get; set; }
        public string? Category { get; set; }
        public string? Department { get; set; }

    }

    public List<Person> _people =
    [
        new() { Id = 1, Name = "Bob", Age = 30, JobTitle = "Developer", Location = "New York", Category = "A", Department = "IT" },
        new() { Id = 2, Name = "Alice", Age = 25, JobTitle = "Support", Location = "London", Category = "B", Department = "HR" },
        new() { Id = 3, Name = "John", Age = 40, JobTitle = "Manager", Location = "Paris", Category = "C", Department = "Finance" },
        new() { Id = 4, Name = "Emily", Age = 35, JobTitle = "Marketing", Location = "Berlin", Category = "D", Department = "Marketing" },
        new() { Id = 5, Name = "David", Age = 28, JobTitle = "Sales", Location = "Tokyo", Category = "E", Department = "Sales" },
        new() { Id = 6, Name = "Sophia", Age = 32, JobTitle = "Designer", Location = "Milan", Category = "F", Department = "Design" },
        new() { Id = 7, Name = "Liam", Age = 29, JobTitle = "Analyst", Location = "Toronto", Category = "G", Department = "Analytics" },
        new() { Id = 8, Name = "Olivia", Age = 27, JobTitle = "Consultant", Location = "Sydney", Category = "H", Department = "Consulting" },
        new() { Id = 9, Name = "Noah", Age = 34, JobTitle = "Engineer", Location = "San Francisco", Category = "I", Department = "Engineering" },
        new() { Id = 10, Name = "Ava", Age = 31, JobTitle = "HR", Location = "Dubai", Category = "J", Department = "HR" },
        new() { Id = 11, Name = "Mason", Age = 26, JobTitle = "Developer", Location = "New York", Category = "A", Department = "IT" },
        new() { Id = 12, Name = "Isabella", Age = 24, JobTitle = "Support", Location = "London", Category = "B", Department = "HR" },
        new() { Id = 13, Name = "James", Age = 45, JobTitle = "Manager", Location = "Paris", Category = "C", Department = "Finance" },
        new() { Id = 14, Name = "Mia", Age = 33, JobTitle = "Marketing", Location = "Berlin", Category = "D", Department = "Marketing" },
        new() { Id = 15, Name = "Benjamin", Age = 29, JobTitle = "Sales", Location = "Tokyo", Category = "E", Department = "Sales" },
        new() { Id = 16, Name = "Charlotte", Age = 30, JobTitle = "Designer", Location = "Milan", Category = "F", Department = "Design" },
        new() { Id = 17, Name = "Elijah", Age = 28, JobTitle = "Analyst", Location = "Toronto", Category = "G", Department = "Analytics" },
        new() { Id = 18, Name = "Amelia", Age = 27, JobTitle = "Consultant", Location = "Sydney", Category = "H", Department = "Consulting" },
        new() { Id = 19, Name = "Lucas", Age = 35, JobTitle = "Engineer", Location = "San Francisco", Category = "I", Department = "Engineering" },
        new() { Id = 20, Name = "Harper", Age = 32, JobTitle = "HR", Location = "Dubai", Category = "J", Department = "HR" },
        new() { Id = 21, Name = "Henry", Age = 31, JobTitle = "Developer", Location = "New York", Category = "A", Department = "IT" },
        new() { Id = 22, Name = "Evelyn", Age = 26, JobTitle = "Support", Location = "London", Category = "B", Department = "HR" },
        new() { Id = 23, Name = "Alexander", Age = 44, JobTitle = "Manager", Location = "Paris", Category = "C", Department = "Finance" },
        new() { Id = 24, Name = "Abigail", Age = 34, JobTitle = "Marketing", Location = "Berlin", Category = "D", Department = "Marketing" },
        new() { Id = 25, Name = "Sebastian", Age = 27, JobTitle = "Sales", Location = "Tokyo", Category = "E", Department = "Sales" },
        new() { Id = 26, Name = "Ella", Age = 31, JobTitle = "Designer", Location = "Milan", Category = "F", Department = "Design" },
        new() { Id = 27, Name = "Jack", Age = 29, JobTitle = "Analyst", Location = "Toronto", Category = "G", Department = "Analytics" },
        new() { Id = 28, Name = "Scarlett", Age = 28, JobTitle = "Consultant", Location = "Sydney", Category = "H", Department = "Consulting" },
        new() { Id = 29, Name = "Daniel", Age = 36, JobTitle = "Engineer", Location = "San Francisco", Category = "I", Department = "Engineering" },
        new() { Id = 30, Name = "Grace", Age = 33, JobTitle = "HR", Location = "Dubai", Category = "J", Department = "HR" },
        new() { Id = 31, Name = "Matthew", Age = 30, JobTitle = "Developer", Location = "New York", Category = "A", Department = "IT" },
        new() { Id = 32, Name = "Chloe", Age = 25, JobTitle = "Support", Location = "London", Category = "B", Department = "HR" },
        new() { Id = 33, Name = "Aiden", Age = 43, JobTitle = "Manager", Location = "Paris", Category = "C", Department = "Finance" },
        new() { Id = 34, Name = "Victoria", Age = 35, JobTitle = "Marketing", Location = "Berlin", Category = "D", Department = "Marketing" },
        new() { Id = 35, Name = "Jackson", Age = 28, JobTitle = "Sales", Location = "Tokyo", Category = "E", Department = "Sales" },
        new() { Id = 36, Name = "Aria", Age = 30, JobTitle = "Designer", Location = "Milan", Category = "F", Department = "Design" },
        new() { Id = 37, Name = "Logan", Age = 29, JobTitle = "Analyst", Location = "Toronto", Category = "G", Department = "Analytics" },
        new() { Id = 38, Name = "Lily", Age = 27, JobTitle = "Consultant", Location = "Sydney", Category = "H", Department = "Consulting" },
        new() { Id = 39, Name = "David", Age = 37, JobTitle = "Engineer", Location = "San Francisco", Category = "I", Department = "Engineering" },
        new() { Id = 40, Name = "Zoey", Age = 32, JobTitle = "HR", Location = "Dubai", Category = "J", Department = "HR" },
        new() { Id = 41, Name = "Joseph", Age = 31, JobTitle = "Developer", Location = "New York", Category = "A", Department = "IT" },
        new() { Id = 42, Name = "Hannah", Age = 26, JobTitle = "Support", Location = "London", Category = "B", Department = "HR" },
        new() { Id = 43, Name = "Samuel", Age = 42, JobTitle = "Manager", Location = "Paris", Category = "C", Department = "Finance" },
        new() { Id = 44, Name = "Lillian", Age = 34, JobTitle = "Marketing", Location = "Berlin", Category = "D", Department = "Marketing" },
        new() { Id = 45, Name = "Gabriel", Age = 27, JobTitle = "Sales", Location = "Tokyo", Category = "E", Department = "Sales" },
        new() { Id = 46, Name = "Natalie", Age = 30, JobTitle = "Designer", Location = "Milan", Category = "F", Department = "Design" },
        new() { Id = 47, Name = "Carter", Age = 29, JobTitle = "Analyst", Location = "Toronto", Category = "G", Department = "Analytics" },
        new() { Id = 48, Name = "Addison", Age = 27, JobTitle = "Consultant", Location = "Sydney", Category = "H", Department = "Consulting" },
        new() { Id = 49, Name = "Mason", Age = 35, JobTitle = "Engineer", Location = "San Francisco", Category = "I", Department = "Engineering" },
        new() { Id = 50, Name = "Ava", Age = 32, JobTitle = "HR", Location = "Dubai", Category = "J", Department = "HR" }
    ];
}

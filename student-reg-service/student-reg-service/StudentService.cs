using System.Text.Json;

namespace student_reg_service
{
    public class StudentService
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<Student> getData()
        {
            var data = client.GetStreamAsync("https://jsonplaceholder.typicode.com/todos/1");
            var result = await JsonSerializer.DeserializeAsync<Student>(await data);
            return result;

        }
    }
}

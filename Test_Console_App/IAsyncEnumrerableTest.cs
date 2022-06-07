namespace Test_Console_App;

internal class AsyncEnumerableTest
{

    public async void Execute()
    {
        Console.WriteLine("Get Document Objects");

        Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} Start");

        foreach (var documentObject in await GetDocumentObjects())
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} DocumentObject id: {documentObject.Id}, name: {documentObject.Name}");
        }

        Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} Finished");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Get Document Objects IAsyncEnumerable");

        Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} Start");

        await foreach (var documentObject in GetDocumentObjectsIAsyncEnumerable())
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} DocumentObject id: {documentObject.Id}, name: {documentObject.Name}");
        }

        Console.WriteLine($"{DateTime.Now:HH:mm:ss:fff} Finished");

        Console.ReadLine();
    }

    private static async Task<IEnumerable<SimpleDocumentObject>> GetDocumentObjects()
    {
        IList<SimpleDocumentObject> documentObjects = new List<SimpleDocumentObject>();

        for (var i = 0; i < 10; i++)
        {
            await Task.Delay(500);
            documentObjects.Add(new SimpleDocumentObject { Id = i, Name = $"Name: {i}" });
        }

        return documentObjects;
    }

    private static async IAsyncEnumerable<SimpleDocumentObject> GetDocumentObjectsIAsyncEnumerable()
    {
        for (var i = 0; i < 10; i++)
        {
            await Task.Delay(500);
            yield return new SimpleDocumentObject { Id = i, Name = $"Name: {i}" };
        }
    }  
}
public class SimpleDocumentObject
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
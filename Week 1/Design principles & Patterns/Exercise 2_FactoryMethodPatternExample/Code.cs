using System;

#region Document Interface and Classes

// Common interface for all document types
public interface IDocument
{
    void Open();
}

// Concrete implementation for Word Document
public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Word document...");
    }
}

// Concrete implementation for PDF Document
public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF document...");
    }
}

// Concrete implementation for Excel Document
public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Excel document...");
    }
}

#endregion

#region Factory Classes

// Abstract Factory class
public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// Concrete factory for Word documents
public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

// Concrete factory for PDF documents
public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

// Concrete factory for Excel documents
public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

#endregion

#region Program Class (Testing the Pattern)

class Program
{
    static void Main(string[] args)
    {
        // Create a Word document using factory
        DocumentFactory wordFactory = new WordDocumentFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        // Create a PDF document using factory
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        // Create an Excel document using factory
        DocumentFactory excelFactory = new ExcelDocumentFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();
    }
}

#endregion

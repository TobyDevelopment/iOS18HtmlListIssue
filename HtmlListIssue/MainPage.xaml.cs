namespace HtmlListIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
        this.unorderedList.Text = "<ul><li>item 1</li><li>item 2</li><li>item 3</li></ul>";
        this.orderedList.Text = "<ol><li>item 1</li><li>item 2</li><li>item 3</li></ol>";
    }
}
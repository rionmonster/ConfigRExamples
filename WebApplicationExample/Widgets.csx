using WebApplicationExample.Models;

// Build a collection of widgets, which we will store in the application
var widgets = new List<Widget>();

// Build a few widgets
widgets.Add(new Widget(){
                SerialNumber = Guid.NewGuid(),
		Description = "Widget A",
		Parts = new List<WidgetPart>() { new WidgetPart(1, "Motorized Arm"), new WidgetPart(2, "Voice Module", false) }
           });
widgets.Add(new Widget(){
                SerialNumber = Guid.NewGuid(),
		Description = "Widget B",
		Parts = new List<WidgetPart>() { new WidgetPart(4, "Kung Fu Grip") }
           });;
widgets.Add(new Widget(){
                SerialNumber = Guid.NewGuid(),
	        Description = "Widget C",
		Parts = new List<WidgetPart>() { }
           });;

// Add these widgets to the config
Add("Widgets", widgets);
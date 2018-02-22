$(function
$("#sbHome").addClass("active");
    ko.applyBindings(new ViewModel());
})

var tmpobject = function(id, value){
    this.ID = id;
    this.Value = value;
}

function ViewModel(){
    var self = this;
    //setup objects in an observable array
    this.objects = ko.observableArray([]);
    self.objects.push(new tmpobject(1, 'item1'));
    self.objects.push(new tmpobject(2, 'item2'));
    self.objects.push(new tmpobject(3, 'item3'));
    self.objects.push(new tmpobject(4, 'item4'));
    self.objects.push(new tmpobject(5, 'item5'));

    self.title = ko.observable("This is the title of the Card");
    self.subtitle = ko.observable("This is the subtitle of the Card");
    self.body = ko.observable("This is the body of the Card");
    self.footer = ko.observable("This is the footer of the Card");

    //setup kendo Grid

    $("kendoGrid").kendoGrid({
        dataSource:{
            data:ko.toJS(self.objects)
        },
        pagable:false,
        scrollable:false,
        sortable:true,
        groupable:false,
        filterable:true,
        sort:{field:"value", dir:"desc"},

        columns:[
        {field:ID, title: "object ID", groupable: false, filterable:{multi:true}},
        {field: "Value", title:"object Value", groupable:false, filterable:false},
        {command:{text:" ", click:showDetails, iconClass:"fa fa-pencil-square-o"}, title:" ", width: "100px"}
        ]

    }).data("kendoGrid");

    function showDetails(args)
    {
        args.preventDefault();
        var dataItem = this.dataItem($(args.currentTarget).closest("tr"));
        alert("clicked Edit for Item: " + dataItem.ID);
    }

}
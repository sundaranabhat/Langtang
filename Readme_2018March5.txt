
--------------
Scar Index Search

1) Uitlity Controller -> GetScarSSN()
2) BusinessAccessLayer-> GetList()
3) DataAccessLayer-> Service ->  List<ViewPersonnalModel> GetViewList();
								ViewPersonnalModel JPasPersonnal(int id); // please check the parameter, if it has string change to int.
4) DataAccessLayer-> Implementation -> GetViewList()
										JPasPersonnal(int id) // please check the parameter, if it has string change to int.
5) View -> Scar->Index 
	Add Jquery
	Add  <li class="searchbox">
                        <input type="text" class="form-control mr-sm-2" placeholder="SSN" name="ScarSearchText" id="ScarSearchText" autocomplete="off"> // please take ID
                        <input type="button" class="k-button my-2 my-sm-0" id="btnScarSearchId" value="Search" />
          </li>
	Add Kendo Autocomplete jquery.
	
---------- ------____PDF --------------------
6) In NAbbar2, Add Link for pdf .
7) Create new folder as File
8) Add one PDF file as name PDF.pdf
       
----------------------------------

    $("#ScarSearchText").kendoAutoComplete({
        datasource: {
                    transport: {
                        read: {
                            url: "/utility/GetScarSSN",
                                datatype: "json"
                            }
                        }
                    },
            datatextfield: "firstname",
            datavaluefield: "profileid",
            filter: "contains",
            minlength: 2,
            select: function (e) {
                // alert();
                var dataitem = this.dataitem(e.item.index());
                var url = "/personnal/search/"+ dataitem.id;
                window.location.assign(url);
            },
            change: function (e) {
                this.value("");
                this.close();
            }
    }).data("kendoAutoComplete").focus();
	
	
	------------- March 8 2018-----------
	1) Change on View , Views-> Scar-> Index 
		datetime picker 
		(use moment.js, bootstrap datetimepicker jquery, bootstrap datetimepicker css)
		
		HTML: 
		 <div class="form-group">
            <input type='text' class="form-control date" id="SN" />
            <input type='text' class="form-control date" id="TS" />

        </div>
		
		Jquery: 
		
		
		<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.10.6/moment.min.js"></script>
		<script src="~/Scripts/jquery-1.10.2.min.js"></script>
		<script src="~/Scripts/bootstrap.min.js"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/js/bootstrap-datetimepicker.min.js"></script>
		<script src="~/Scripts/knockout-3.4.2.js"></script>
		<script src="~/Scripts/Kendo/kendo.all.js"></script>
		<script src="~/Scripts/Kendo/kendo.web.js"></script>
		<script src="~/Scripts/Kendo/kendo.aspnetmvc.min.js"></script>

		
		<script>
			
			$('#SN').datetimepicker({
			format: 'YYYY/MM/DD',
			allowInputToggle: true,
			useCurrent: false 
			});
		
			$('#TS').datetimepicker({
			format: 'YYYY/MM/DD',
			allowInputToggle: true,
			useCurrent: false 
			});

		</script>

		
		
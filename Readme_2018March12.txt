-------------- March 12 2018 ----------------------




<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.10.6/moment.min.js"></script>
<script src="~/Scripts/jquery-1.10.2.min.js"></script>
<script src="~/Scripts/bootstrap.min.js"></script>
<script src="~/Scripts/bootstrap-datetimepicker.js"></script>
<script src="~/Scripts/knockout-3.4.2.js"></script>
<script src="~/Scripts/Kendo/kendo.all.js"></script>
<script src="~/Scripts/Kendo/kendo.web.js"></script>
<script src="~/Scripts/Kendo/kendo.aspnetmvc.min.js"></script>


<script>
    $('#SN').datetimepicker({
        format: "yyyy/mm/dd",
        minView: 2,
        pickTime: false,
        autoclose: true,
        allowInputToggle: true,
        useCurrent: false

    });
    $('#TS').datetimepicker({
        format: "yyyy/mm/dd",
        minView: 2,
        pickTime: false,
        autoclose: true,
        allowInputToggle: true,
        useCurrent: false
    });

</script>
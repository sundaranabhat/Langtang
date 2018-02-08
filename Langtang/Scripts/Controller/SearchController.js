app.controller("SearchController", function ($scope, $http, SearchService) {

    toggleDiv = function (divEmpty, divPersonalList, insertForm, divDetail) {
        console.log(divDetail);
        $scope.divEmpty = divEmpty;
        $scope.divpersonnallist = divPersonalList;
        $scope.InsertForm = insertForm;
        $scope.divDetail = divDetail;
    }
    $scope.search = function () {
        toggleDiv(false, true, false, false);


        SearchService.getSearch($scope.searchText).then(function (response) {
            debugger;
            if (response.data.length !== 0) {
                toggleDiv(false, true, false, false);
                $scope.personnalList = response.data;
            }
            else {
                toggleDiv(true, false, false, false);
            }
        }, function () {
            alert("Failed to Retrieve");
        });

    };
    $scope.ShowInsertForms = function () {
        toggleDiv(false, false, true, false);
        // debugger;
        //$scope.InsertForm = true;
        //$scope.divEmpty = false;
        //$scope.divDetail = false;

        document.getElementById("ID").value = 0;
        $scope.FIRSTNAME = "";
        $scope.LASTNAME = "";
        $scope.DODID = "";
        document.getElementById('labelName').innerHTML = "Insert Personnal Information";
        document.getElementById("btnSave").setAttribute("value", "Submit");
        //  document.getElementById("ID").value = 0;

    }
    $scope.InsertData = function () {
        // debugger;
        var Action = document.getElementById("btnSave").getAttribute("value");

        if (Action === "Submit") {
            document.getElementById('labelName').innerHTML = "Insert Personnal Information";

            $scope.personnalModel = {};
            $scope.personnalModel.FIRSTNAME = $scope.FIRSTNAME;
            $scope.personnalModel.LASTNAME = $scope.LASTNAME;
            $scope.personnalModel.DODID = $scope.DODID;

            SearchService.Insert($scope.personnalModel).then(function (response) {
                alert(response.data);
                $scope.FIRSTNAME = "";
                $scope.LASTNAME = "";
                $scope.DODID = "";
            })
        }
        else {
            $scope.personnalModel = {};
            $scope.personnalModel.FIRSTNAME = $scope.FIRSTNAME;
            $scope.personnalModel.LASTNAME = $scope.LASTNAME;
            $scope.personnalModel.DODID = $scope.DODID;
            $scope.personnalModel.ID = document.getElementById("ID").value;

            SearchService.Update($scope.personnalModel).then(function (response) { // pass parameter $scope.personnalModel
                alert(response.data);
                $scope.FIRSTNAME = "";
                $scope.LASTNAME = "";
                $scope.DODID = "";
                document.getElementById("btnSave").setAttribute("value", "Submit");
            })
        }

    }
    $scope.UpdateData = function (personnal) {
        // alert(personnal);
        // debugger;
        document.getElementById('labelName').innerHTML = "Update Personnal Information";
        toggleDiv(false, false, true, false);

        //$scope.InsertForm = true;
        //$scope.divEmpty = false;
        //$scope.divpersonnallist = false;
        //$scope.divDetail = false;

        document.getElementById("ID").value = personnal.ID;
        $scope.FIRSTNAME = personnal.FIRSTNAME;
        $scope.LASTNAME = personnal.LASTNAME;
        $scope.DATEOFBIRTH = personnal.DATEOFBIRTH;
        $scope.DODID = personnal.DODID;
        document.getElementById("btnSave").setAttribute("value", "Update");
    }
    $scope.Back = function () {
        $scope.search(); // call search function
    }
    $scope.Detail = function (personnal) {

        SearchService.Detail(personnal).then(function (response) {
            toggleDiv(false, false, false, true);

            //$scope.divEmpty = false;
            //$scope.divpersonnallist = false;
            //$scope.InsertForm = false;
            //$scope.divDetail = true;
            console.log(response.data);
            document.getElementById("ID").value = personnal.ID;
            $scope.Detail_FirstName = personnal.FIRSTNAME;
            $scope.Detail_LastName = personnal.LASTNAME;
            $scope.Detail_DODID = personnal.DODID;

        })
    }

})
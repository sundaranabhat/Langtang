app.controller("ViewPersonnalCtrl", function ($scope, $http, vPersonnalService) {

    toggleDiv = function (divEmpty, divPersonalList, insertForm, divDetail) {
        console.log(divDetail);
        $scope.divEmpty = divEmpty;
        $scope.divpersonnallist = divPersonalList;
        $scope.InsertForm = insertForm;
        $scope.divDetail = divDetail;
    }
    $scope.search = function () {
        toggleDiv(false, true, false, false);

        debugger;
        vPersonnalService.getSearch().then(function (response) {
            debugger;
            if (response.data.length !== 0) {
                toggleDiv(false, true, false, false);
                $scope.vpersonnalList = response.data;
            }
            else {
                toggleDiv(true, false, false, false);
            }
        }, function () {
            alert("Failed to Retrieve");
        });

    };

})
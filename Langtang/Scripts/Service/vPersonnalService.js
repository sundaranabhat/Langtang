app.service("vPersonnalService", function ($http) {
    return {
        getSearch: function () {
            return $http({
                method: "GET",
                url: "/Search/ViewSearch",
                datatype: "json",
                //data: { searchText: searchName },
                headers: { "Content-Type": "application/json" }
            });
        }
    }
});
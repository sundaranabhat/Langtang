app.service("SearchService", function ($http) {
    return {
        getSearch: function (searchName) {
            return $http({
                method: "POST",
                url: "/Search/Search",
                datatype: "json",
                data: { searchText: searchName },
                headers: { "Content-Type": "application/json" }
            });
        },
        Insert: function (personnalModel) {
            return $http({
                method: "POST",
                url: "/Search/Insert",
                datatype: "json",
                data: JSON.stringify(personnalModel),
                headers: { "Content-Type": "application/json" }
            });
        },
        Update: function (personnalModel) {
            //  console.log(personnalModel);
            return $http({
                method: "POST",
                url: "/Search/Update",
                datatype: "json",
                data: JSON.stringify(personnalModel)
            });
        },
        Detail: function (personnalModel) {
            return $http({
                method: "POST",
                url: "/Search/Detail",
                datatype: "json",
                data: JSON.stringify(personnalModel)
            });
        }
    }
})
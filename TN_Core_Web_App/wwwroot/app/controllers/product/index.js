var productController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
        loadCategories();
    }

    function registerEvents() {
        //todo: binding events to controls
        $('#ddlShowPage').on('change', function () {
            tn.configs.pageSize = $(this).val();
            tn.configs.pageIndex = 1;
            loadData(true);
        });
        $('#btnSearch').on('click', function () {
            loadData();
        });
        $('#txtKeyword').on('keypress', function (e) {
            if (e.which === 13) {
                loadData();
            }
        });
    }
    function loadCategories() {
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAllCategories',
            dataType: 'json',
            success: function (response) {
                var render = "<option value=''>--Select category--</option>";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.Id + "'>" + item.Name + "</option>"
                });
                $('#ddlCategorySearch').html(render);
            },
            error: function (status) {
                console.log(status);
                tn.notify('Cannot loading product category data', 'error');
            }
        });
    }
    function loadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: $('#ddlCategorySearch').val(),
                keyword: $('#txtKeyword').val(),
                page: tn.configs.pageIndex,
                pageSize: tn.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (response) {
                console.log(response);
                $.each(response.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: tn.formatNumber(item.Price, 0),
                        CreatedDate: tn.dateTimeFormatJson(item.DateCreated),
                        Status: tn.getStatus(item.Status)
                    });
                    $('#lblTotalRecords').text(response.RowCount);
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                    wrapPaging(response.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log(status);
                tn.notify('Cannot loading data', 'error');
            }
        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / tn.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                tn.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}
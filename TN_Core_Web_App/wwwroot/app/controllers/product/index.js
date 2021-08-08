
// khởi tạo 1 đối tượng dạng function
var productController = function () {
    // phương thức tĩnh  gắn với từ khóa this có nghĩa là phương thức này được gọi trực tiếp từ productController 
    //
    this.initialize = function () {
        loadData();
    }
    function regsigterEvents() {

    }
    // phương thức load dữ liệu ra 
    function loadData() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'json',
            success: function (response) {
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: tn.formatNumber(item.Price, 0),
                        CreatedDate: tn.dateTimeFormatJson(item.DateCreated),
                        Status: tn.geStatus (item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                tn.notify('Cannot loading data', 'error');
            }
        })
    }
}
$(document).ready(function () {


    $(".detail-modal-btn").on("click", function () {

        var dataId = $(this).data("id");
            
            $.ajax(
                {
                    url: `/home/getBook/${dataId}`,
                    method: "get",
                    success: function (res) {
                       
                        console.log(res);
                        $("#detailModal .modal-content").html(res)
                    }
                }
        )



        $("#detailModal").modal('show')
        })

        //var dataId = $(this).data("id");
        //console.log(dataId);

        //$(fetch(`/home/getBook/${dataId}`))
        //    .then(response => response.text())
        //    .then(data => {
        //        console.log(data)

        //        $("#detailModal .modal-content").html(data)

    //   });

    $(".add-basket-btn").on("click", function (e) {

        e.preventDefault();

        let urlBasket = $(this).attr("href");
        console.log(urlBasket);

        $(fetch(urlBasket))
            .then(response => {
                console.log(response)
            })
            
    })
    

    
    

        
            

        
    });








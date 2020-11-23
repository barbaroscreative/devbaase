
$(document).ready(function () {
   $(" #silmeEkrani").on("show.bs.modal",function(event){
       let tetikleyenElement = $(event.relatedTarget);
       let id = tetikleyenElement.data("barbaros");

       $("#btnSil").click(function () {
           $.ajax({
                type: "Get",
                url: "./Category/Delete",
                data: { id: id },
                dataType: "json",
                contentType: "application/json; charset =utf-8;",
                 success: function () {
                    alert("işlem tamam");
                 },
                  erroe: function (error) {
                    alert(error.statusText);
                   }
            })
        });
    })
});
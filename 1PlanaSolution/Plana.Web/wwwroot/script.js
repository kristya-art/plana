
var clickCount = 0;

function renderjQueryComponents() {
    $("#accordion").accordion();
    $(".jquery-btn button").button();
    $(".jquery-btn button").click(function () {
        console.log('Clicked');
        $('.click-count')[0].innerText = ++clickCount;

    });

}


function GetName() {
    alert("Name");
}

function SetButtonsVisible() {
    $('#edit-btn').click(function (){
        $(this).hide();
        $(this).siblings('#save-btn, #delete-btn, #cancel-btn ').show();
    });
    $('#save-btn').click(function () {
        $(this).hide();
        $(this).siblings('#delete-btn,#cancel-btn').hide();
        $(this).siblings('#edit-btn').show();
    });
}



$('#edit-btn').click(function () {
    $(this).hide();
    $(this).siblings('#save-btn, #delete-btn, #cancel-btn ').show();
});
$('#save-btn').click(function () {
    $(this).hide();
    $(this).siblings('#delete-btn,#cancel-btn').hide();
    $(this).siblings('#edit-btn').show();
});

function searchlocal1() {
    //alert(document.getElementById("searchtext").value);  
    var local = new BMap.LocalSearch(map, { renderOptions: { map: map} });
    local.search(document.getElementById("searchtext").value);
}
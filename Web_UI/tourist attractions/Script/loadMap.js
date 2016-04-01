var map = new BMap.Map("map"); // 创建地图实例   
    var point = new BMap.Point(116.404, 39.915); // 创建点坐标   
    map.centerAndZoom(point, 15); // 初始化地图，设置中心点坐标和地图级别     
    map.addControl(new BMap.NavigationControl());    
    map.addControl(new BMap.ScaleControl());      
    map.enableScrollWheelZoom();//滚轮缩放事件  
   map.enableKeyboard(); //键盘方向键缩放事件  
    map.enableContinuousZoom(); // 开启连续缩放效果  
    map.enableInertialDragging();　// 开启惯性拖拽效果           


    function searchlocal1() {
        //alert(document.getElementById("searchtext").value);  
        var local = new BMap.LocalSearch(map, { renderOptions: { map: map} });
        local.search(document.getElementById("searchtext").value);
    }  
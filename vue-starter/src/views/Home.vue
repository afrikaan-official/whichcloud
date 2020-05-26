<template>
<body>
  <div class="container" id="app">
    <div class="row">
      <div class="col col-md-12">
        <pre class="title">
   __      __  __                  __          ____    ___                       __     
  /\ \  __/\ \/\ \      __        /\ \        /\  _`\ /\_ \                     /\ \    
  \ \ \/\ \ \ \ \ \___ /\_\    ___\ \ \___    \ \ \/\_\//\ \     ___   __  __   \_\ \   
   \ \ \ \ \ \ \ \  _ `\/\ \  /'___\ \  _ `\   \ \ \/_/_\ \ \   / __`\/\ \/\ \  /'_` \  
    \ \ \_/ \_\ \ \ \ \ \ \ \/\ \__/\ \ \ \ \   \ \ \L\ \\_\ \_/\ \L\ \ \ \_\ \/\ \L\ \ 
     \ `\___x___/\ \_\ \_\ \_\ \____\\ \_\ \_\   \ \____//\____\ \____/\ \____/\ \___,_\
      '\/__//__/  \/_/\/_/\/_/\/____/ \/_/\/_/    \/___/ \/____/\/___/  \/___/  \/__,_ /
        </pre>
      </div>
    </div>
    <div class="row" style="color:#ccc;margin-top:6.5%;">
      <div class="col">
        <span class="float-right" style="margin-right: 6.5%;">Last Update: {{ date }}</span>
        <span class="float-left">
          Currency:
          <select style="border: dashed 2px #ccc;">
            <option>$</option>
          </select>
        </span>
      </div>
    </div>
    <div class="row" style="margin-bottom:1%">
      <div class="col col-md-2 mt-4">
        <nav class="nav flex-column">
          <a class="nav-link active" href="vm">
            VM
            <span class="badge badge-pill badge-warning up ml-2 align-text-bottom">beta</span>
          </a>
          <a class="nav-link" href="database">
            Database
            <span class="badge badge-pill badge-warning up ml-2 align-text-bottom">soon</span>
          </a>
          <a class="nav-link" href="storage">
            Storage
            <span class="badge badge-pill badge-warning up ml-2 align-text-bottom">soon</span>
          </a>
        </nav>
      </div>

      <div class="col col-md-9 ml-4 mt-1">
        <router-view />
      </div>
    </div>
  </div>
  <div class="fixed-bottom ml-2" style="color: #ccc;">
    <a href="#">about</a>
  </div>
</body>
</template>

<script>
export default {
  name: "Home",
  date: function() {
    return {
      count: 0
    };
  }
};
</script>

<style>
body {
  background-color: black;
  font-family: "Ubuntu", sans-serif;
}

a {
  color: #ccc;
}

a.active {
  border: dashed;
}

a:hover {
  color: #ffc107;
}

.title {
  margin-left: 20%;
  margin-top: 4.5%;
  color: #ccc;
}

table {
  color: #ccc;
  border-collapse: collapse;
  font-size: medium;
}

table tr {
  color: #ccc;
  border: dashed 3px;
}

table th {
  color: #ccc;
  border: dashed 2px;
}

table td {
  color: #ccc;
  border: dashed 2px;
}

thead {
  text-align: center;
}
</style>
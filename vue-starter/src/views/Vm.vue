<template>
   <div class="card" style="background-color:black; color: #ccc;border: dashed 1px #ccc;">
          <div class="card-header">
            <ul class="nav nav-tabs card-header-tabs" id="price-table" role="tablist">
              <li class="nav-item">
                <a
                  class="nav-link active"
                  style="color:#ccc;background-color: black"
                  href="#standard"
                  role="tab"
                  aria-controls="standard"
                  aria-selected="true"
                >Standard</a>
              </li>
              <li class="nav-item">
                <a
                  class="nav-link disabled"
                  style="color:#ccc;background-color:black"
                  href="#general"
                  role="tab"
                  aria-controls="history"
                  aria-selected="false"
                >General</a>
              </li>
              <li class="nav-item">
                <a
                  class="nav-link disabled"
                  style="color:#ccc;background-color: black"
                  href="#optimized"
                  role="tab"
                  aria-controls="deals"
                  aria-selected="false"
                >Optimized</a>
              </li>
            </ul>
          </div>
          <div class="card-body">
            <div
              class="card-text text-center"
            >Standard VM's has shared CPU and RAM. They are ideal for staging environments.</div>
            <div class="tab-content mt-3">
              <div
                class="tab-pane active"
                id="standard"
                role="tabpanel"
                style="height: 650px;overflow: auto;"
              >
                <table class="table table-striped table-bordered table-md">
                  <thead>
                    <tr>
                      <th scope="col">Memory</th>
                      <th scope="col">CPU</th>
                      <th scope="col">Storage</th>
                      <th scope="col">Bandwidth</th>
                      <th scope="col">Price (mo)</th>
                      <th scope="col">Source</th>
                    </tr>
                  </thead>
                  <tbody>
                    <!-- @foreach (var vm in Model)
                      {
                        <tr>
                          <td>@vm.Memory GB</td>
                          <td>@vm.CPU Core</td>
                          <td>@vm.Storage GB SSD</td>
                          <td>@vm.Bandwidth TB</td>
                          <td>@vm.Price.ToString("c",new CultureInfo(("en-US")))</td>
                          <td><a href="@vm.Link">@vm.Source</a></td>
                        </tr>
                    }-->
                  </tbody>
                </table>
              </div>
              <div class="tab-pane" id="general" role="tabpanel" aria-labelledby="general-tab"></div>
              <div class="tab-pane" id="optimized" role="tabpanel" aria-labelledby="optimized-tab"></div>
            </div>
          </div>
        </div>
</template>
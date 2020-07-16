<template>
  <div>
    <h3>Page to add/remove adminprivilegies</h3>
    <div class="tableDiv">
      <table>
        <tr class="headers bord p-3 mb-2 bg-warning text-dark">
          <th>
            <b-button v-b-modal.modal-prevent-closing>Add New Admin</b-button>
          </th>
          <th>Name</th>
          <th class="p-3">Action</th>
        </tr>
        <tr v-for="(admin, index) in currentAdministrators" :key="index">
            <td></td>
          <td>{{admin.name }}</td>
          <td>
            <b-button variant="outline-warning">Remove Admin</b-button>
          </td>
        </tr>
      </table>
    </div>
    <b-modal id="modal-prevent-closing" ref="modal" title="Submit New Admin" @ok="addNewAdmin()">
      <b-form-input type="text" placeholder="Admin Name" v-model="newAdminName.name"></b-form-input>
    </b-modal>
  </div>
</template>
<script>
export default {
  name: "AdminAdministration",
  data() {
    return {
      currentAdministrators: [
        { name: "Bjernt" },
        { name: "Bertrude" },
        { name: "Magna." }
      ],
      newAdminName: { name: "" }
    };
  },
  methods: {
    addNewAdmin() {
      console.log(this.newAdminName, " admin name når OK klikkes");
      this.currentAdministrators.push(this.newAdminName);
    }
  }
};
</script>

<style scoped>
.tableDiv {
  width: 50vw;
  position: relative;
  display: flex;
  flex-flow: column wrap;
  margin: 0 auto;
  text-align: center;
}
td {
  width: 200px;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: bold;
}
tr:hover {
  background-color: rgba(240, 184, 32, 0.157);
}
.bord {
  border: solid black 3px;
}
.headers:hover {
  pointer-events: none;
}
</style>
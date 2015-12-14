function Employee(id, name, salary){
    //this.id = id;
    this._id = id;


    this.name = name;
    this.salary = salary;
}
Employee.prototype.getId = function(){
    return this._id;
};
Employee.prototype.display = function(){
    console.log(this.id, this.name, this.salary);
}

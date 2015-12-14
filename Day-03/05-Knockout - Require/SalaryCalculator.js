define(["knockout"], function(ko){
      function SalaryCalculator(){
            this.basic = ko.observable(0);
            this.hra = ko.observable(0);
            this.da = ko.observable(0);
            this.tax = ko.observable(0);
            this.salary = ko.observable(0);
        }
        SalaryCalculator.prototype.calculate = function(){
            var gross = this.basic().toInt() + this.hra().toInt() + this.da().toInt();
            var net = gross * ((100-this.tax().toInt())/100);
            this.salary(net);
        }
        return SalaryCalculator;
});

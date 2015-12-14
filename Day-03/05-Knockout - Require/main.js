Object.prototype.toInt = function(){
        return parseInt(this,10);
    };
    require(["jquery","knockout","SalaryCalculator"], function($, ko, SalaryCalculator){
        $(function(){
            var calculator = new SalaryCalculator();
            ko.applyBindings(calculator);
        })
    })

class Dog:
    def __init__(self, __name):
        self.__happiness = 0
        self.__name = __name
    
    def caress(self):
        self.__happiness += 10
        print("Гав-гав!")
    
    def get_happiness(self):
        return self.__happiness
    
    def set_name(self, name):
        if name.isalpha():
            self.__name = name
            print("Теперь собаку зовут", self.__name,"!")
            return
        else:
            print("В имени должны быть только буквы!!!")
    
    def get_name(self):
        return print("Собаку зовут" ,self.__name)
    
    def bring_item(self, item, rasst=0):
        
        if (rasst <= 100 and self.__happiness >= 10):
            return print(self.__name ,"принес(ла) предмет:", item)
        
        elif (rasst > 100):
            print(item ,"слишком далеко!")
        elif (self.__happiness <10):
            
            print(self.__name ,"нуждается в вашей заботе!")
            
        else:
            print("А тут пусто :)")
            
doggy = Dog("Башмак")
doggy.get_name()
doggy.caress()
print("Уровень счаться собаки =",doggy.get_happiness())
doggy.set_name("Утюг")
doggy.bring_item("Холодильник", 35)

# compiled with BefunCompile v1.0.1 (c) 2015
# execute with at least Python3
from random import randint
def rd():
    return bool(random.getrandbits(1))
def td(a,b):
    return bool(random.getrandbits(1))
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
x0=32
x1=32
x2=32
x3=32
x4=32
def _0():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (20)if(sp()!=0)else(19)
def _1():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (21)if(sp()!=0)else(22)
def _2():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (24)if(sp()!=0)else(28)
def _3():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (28)if(sp()!=0)else(25)
def _4():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (29)if(sp()!=0)else(31)
def _5():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (31)if(sp()!=0)else(30)
def _6():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (32)if(sp()!=0)else(34)
def _7():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (34)if(sp()!=0)else(33)
def _8():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (35)if(sp()!=0)else(27)
def _9():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (27)if(sp()!=0)else(36)
def _10():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (18)if(sp()!=0)else(15)
def _11():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (27)if(sp()!=0)else(26)
def _12():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (34)if(sp()!=0)else(26)
def _13():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (31)if(sp()!=0)else(26)
def _14():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (28)if(sp()!=0)else(26)
def _15():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (18)if((0)if(((1)if((x3)>(x2))else(0))!=0)else(1))else(23)
def _16():
    global x0
    global x1
    global x2
    global x3
    global x4
    return (21)if(x1)else(22)
def _17():
    global x0
    global x1
    global x2
    global x3
    global x4
    x0=1
    x1=1
    x2=99
    x3=99
    return 15
def _18():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((x2)-(1))
    x2=(x2)-(1)
    sa(9)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 0
def _19():
    global x0
    global x1
    global x2
    global x3
    global x4
    x3=99
    return 15
def _20():
    global x0
    global x1
    global x2
    global x3
    global x4
    sp()
    sa(x0)
    sa(x1)
    return 16
def _21():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(sr())
    x4=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(x4)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 1
def _22():
    global x0
    global x1
    global x2
    global x3
    global x4
    sp()
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    print(sp(),end="",flush=True)
    return 37
def _23():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(td(x2,10))
    return 2
def _24():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((td(x2,10))-(td(x3,10)))
    return 3
def _25():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(((x2)*(td(x3,10)))-((x3)*(td(x2,10))))
    return 14
def _26():
    global x0
    global x1
    global x2
    global x3
    global x4
    x0=(x0)*(x2)
    x1=(x1)*(x3)
    return 27
def _27():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((x3)-(1))
    x3=(x3)-(1)
    sa(9)
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 10
def _28():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(td(x2,10))
    return 4
def _29():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((td(x2,10))-(tm(x3,10)))
    return 5
def _30():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(((x2)*(td(x3,10)))-((x3)*(tm(x2,10))))
    return 13
def _31():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(tm(x2,10))
    return 6
def _32():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((tm(x2,10))-(td(x3,10)))
    return 7
def _33():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(((x2)*(tm(x3,10)))-((x3)*(td(x2,10))))
    return 12
def _34():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(tm(x2,10))
    return 8
def _35():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa((tm(x2,10))-(tm(x3,10)))
    return 9
def _36():
    global x0
    global x1
    global x2
    global x3
    global x4
    sa(((x2)*(tm(x3,10)))-((x3)*(tm(x2,10))))
    return 11
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36]
c=17
while c<37:
    c=m[c]()
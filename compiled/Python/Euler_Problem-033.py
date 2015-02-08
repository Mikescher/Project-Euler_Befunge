# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
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
    return (4)if(sp()!=0)else(5)
def _1():
    return (15)if((0)if(((1)if((x3)>(x2))else(0))!=0)else(1))else(7)
def _2():
    global x0
    global x1
    global x2
    global x3
    x0=1
    x1=1
    x2=99
    x3=99
    return 1
def _3():
    global x3
    x3=99
    return 1
def _4():
    global x4
    global x4
    sa(sr())
    x4=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),x4))
    sa(sr())
    return 0
def _5():
    global x1
    sp()
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))
    print(sp(),end="",flush=True)
    return 22
def _6():
    global x0
    global x1
    x0=(x0)*(x2)
    x1=(x1)*(x3)
    return 14
def _7():
    sa(td(x2,10))
    return (20)if(sp()!=0)else(9)
def _8():
    global x0
    global x1
    global x1
    sp()
    sa(x0)
    sa(x1)
    return (4)if(x1)else(5)
def _9():
    sa(td(x2,10))
    return (18)if(sp()!=0)else(10)
def _10():
    sa(tm(x2,10))
    return (16)if(sp()!=0)else(11)
def _11():
    sa(tm(x2,10))
    return (12)if(sp()!=0)else(14)
def _12():
    sa((tm(x2,10))-(tm(x3,10)))
    return (14)if(sp()!=0)else(13)
def _13():
    sa(((x2)*(tm(x3,10)))-((x3)*(tm(x2,10))))
    return (14)if(sp()!=0)else(6)
def _14():
    global x3
    sa((x3)-(1))
    x3=(x3)-(1)
    sa(sp()-(9));
    sa((0)if(sp()!=0)else(1))
    return (15)if(sp()!=0)else(1)
def _15():
    global x2
    sa((x2)-(1))
    x2=(x2)-(1)
    sa(sp()-(9));
    sa((0)if(sp()!=0)else(1))
    return (8)if(sp()!=0)else(3)
def _16():
    sa((tm(x2,10))-(td(x3,10)))
    return (11)if(sp()!=0)else(17)
def _17():
    sa(((x2)*(tm(x3,10)))-((x3)*(td(x2,10))))
    return (11)if(sp()!=0)else(6)
def _18():
    sa((td(x2,10))-(tm(x3,10)))
    return (10)if(sp()!=0)else(19)
def _19():
    sa(((x2)*(td(x3,10)))-((x3)*(tm(x2,10))))
    return (10)if(sp()!=0)else(6)
def _20():
    sa((td(x2,10))-(td(x3,10)))
    return (9)if(sp()!=0)else(21)
def _21():
    sa(((x2)*(td(x3,10)))-((x3)*(td(x2,10))))
    return (9)if(sp()!=0)else(6)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21]
c=2
while c<22:
    c=m[c]()
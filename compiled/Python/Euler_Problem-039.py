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
x5=32
def _0():
    global x0
    global x1
    global x3
    global x4
    global x5
    global x2
    x0=0
    x1=0
    x3=6
    x4=1000
    x5=0
    x2=td(x3,3)
    return 1
def _1():
    global x2
    sa(x2)
    return (2)if((x2)-(2))else(4)
def _2():
    global x2
    sa(sp()-(1));
    x2=sp()
    return (1)if(tm((x3)*((x3)-((2)*(x2))),((x3)-(x2))*(2)))else(3)
def _3():
    global x5
    x5=(x5)+(1)
    return 1
def _4():
    global x5
    sp()
    sa(x5)
    return (9)if((1)if((x5)>(x0))else(0))else(5)
def _5():
    sp()
    return 6
def _6():
    global x3
    sa(x3)
    return (8)if((x3)-(x4))else(7)
def _7():
    global x1
    sp()
    print(x1,end="",flush=True)
    return 10
def _8():
    global x3
    global x5
    global x2
    sa(sp()+(2));
    x3=sp()
    x5=0
    x2=td(x3,3)
    return 1
def _9():
    global x0
    global x1
    global x3
    x0=sp()
    x1=x3
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
# compiled with BefunCompile v1.0.5 (c) 2015
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
x0=20
x1=1
x2=1
x3=48
x4=48
x5=112
def _0():
    return 1
def _1():
    global x1
    global x0
    global x2
    x1=x1*x2
    sa(x0)
    sa(x2+1)
    x2=x2+1
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (3)if(sp()!=0)else(2)
def _2():
    global x1
    print(x1,end="",flush=True)
    return 10
def _3():
    global x3
    x3=1
    return 4
def _4():
    global x3
    global x3
    global x0
    sa(x3)
    x3=x3+1
    sa((1)if(sp()>(x0))else(0))
    return (1)if(sp()!=0)else(5)
def _5():
    return (4)if(tm(x1,x3))else(6)
def _6():
    global x4
    global x5
    x4=td(x1,x3)
    x5=1
    return 7
def _7():
    global x2
    global x5
    sa(x2)
    sa(x5+1)
    x5=x5+1
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (9)if(sp()!=0)else(8)
def _8():
    global x1
    x1=td(x1,x3)
    return 5
def _9():
    return (7)if((0)if(tm(x4,x5)!=0)else(1))else(4)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
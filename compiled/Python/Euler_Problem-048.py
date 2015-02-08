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
def _0():
    return (3)if(sp()!=0)else(2)
def _1():
    global x0
    x0=10000000000
    sa(0)
    sa(1000)
    sa(1000)
    return 0
def _2():
    sp()
    print(sp(),end="",flush=True)
    return 7
def _3():
    global x2
    sa(sr())
    x2=sp()
    sa(sr())
    sa(sr())
    return 6
def _4():
    global x1
    global x0
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(sp()*(x1));
    sa(tm(sp(),x0))
    return 6
def _5():
    global x1
    global x0
    sp()
    sp()
    sa(sp()+(x1));
    sa(tm(sp(),x0))
    sa((x2)-(1))
    sa((x2)-(1))
    return 0
def _6():
    global x1
    x1=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-(1));
    sa(sr())
    return (4)if(sp()!=0)else(5)
m=[_0,_1,_2,_3,_4,_5,_6]
c=1
while c<7:
    c=m[c]()
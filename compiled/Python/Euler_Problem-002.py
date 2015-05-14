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
x0=1
x1=2
x2=2
def _0():
    return 1
def _1():
    global x0
    global x1
    global x0
    global x1
    global x1
    sa(x0)
    sa(x1)
    x0=x1
    sa(sp()+sp());
    sa(sr())
    x1=sp()
    sa(sr())
    sa((1)if(sp()>(10240000))else(0))
    return (5)if(sp()!=0)else(2)
def _2():
    sa(sr())
    sa(sr())
    sa(td(sp(),2))
    sa(sp()*(2));
    v0=sp()
    sa(sp()-v0)
    return (3)if(sp()!=0)else(4)
def _3():
    sp()
    return 1
def _4():
    global x2
    global x2
    sa(sp()+(x2));
    x2=sp()
    return 1
def _5():
    global x2
    print(x2,end="",flush=True)
    sp()
    return 6
m=[_0,_1,_2,_3,_4,_5]
c=0
while c<6:
    c=m[c]()
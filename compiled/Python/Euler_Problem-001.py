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
def _0():
    sa(1)
    sa(2)
    sa(2)
    sa(0)
    return 1
def _1():
    return (9)if(sp()!=0)else(2)
def _2():
    sa(sr())
    sa(sr())
    sa(td(sp(),5))
    sa(sp()*(5));
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (9)if(sp()!=0)else(3)
def _3():
    sa(sr())
    sa(sp()-(1000));
    sa((0)if(sp()!=0)else(1))
    return (4)if(sp()!=0)else(8)
def _4():
    sp()
    sp()
    sp()
    return 5
def _5():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(sp()-(1));
    sa((0)if(sp()!=0)else(1))
    return (6)if(sp()!=0)else(7)
def _6():
    sp()
    print(sp(),end="",flush=True)
    return 10
def _7():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 5
def _8():
    sp()
    sa(sp()+(1));
    sa(sr())
    sa(sr())
    sa(sr())
    sa(td(sp(),3))
    sa(sp()*(3));
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return 1
def _9():
    sa(sr())
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
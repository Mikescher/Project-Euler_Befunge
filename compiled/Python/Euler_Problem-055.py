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
x0=32
x1=32
def _0():
    sa(0)
    sa(10000)
    sa(10000)
    sa(0)
    sa(10000)
    sa(0)
    return 1
def _1():
    return (3)if(sp()!=0)else(2)
def _2():
    global x1
    global x1
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(10));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(tm(sp(),10))
    x1=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(x1));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 1
def _3():
    sp()
    sa(sp()+sp());
    sa(24)
    sa(0)
    return 4
def _4():
    return (14)if(sp()!=0)else(5)
def _5():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 6
def _6():
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (7)if(sp()!=0)else(13)
def _7():
    global x0
    sp()
    sa(sr())
    x0=sp()
    v0=sp()
    sa(sp()-v0)
    return (8)if(sp()!=0)else(9)
def _8():
    global x0
    sa(sr())
    sp()
    sa(sp()+(x0));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-(1));
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 4
def _9():
    sp()
    sp()
    return 10
def _10():
    sa(sp()-(1));
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (11)if(sp()!=0)else(12)
def _11():
    sp()
    print(sp(),end="",flush=True)
    return 15
def _12():
    sa(sr())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 1
def _13():
    global x1
    global x1
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*(10));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(tm(sp(),10))
    x1=sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(x1));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    return 6
def _14():
    sp()
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(1));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 10
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()
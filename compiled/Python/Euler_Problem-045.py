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
    global x0
    global x2
    global x1
    x0=1152921504606846976
    x2=0
    x1=991873
    sa(144)
    sa(991873)
    return 1
def _1():
    global x0
    sa(x0)
    sa((1)if((x0)>(x1))else(0))
    return 2
def _2():
    return (12)if(sp()!=0)else(3)
def _3():
    sa(sr())
    return (4)if(sp()!=0)else(6)
def _4():
    global x2
    global x1
    sa(sr())
    sa(sp()+(x2));
    sa((1)if(sp()>(x1))else(0))
    sa((0)if(sp()!=0)else(1))
    return (11)if(sp()!=0)else(5)
def _5():
    global x2
    x2=td(x2,2)
    sa(td(sp(),4))
    sa(sr())
    return (4)if(sp()!=0)else(6)
def _6():
    sp()
    sa(sp()-((x2)*(x2)));
    sa((0)if(((tm(x2,6))-(5))!=0)else(1))
    return (7)if(sp()!=0)else(10)
def _7():
    sa((0)if(sp()!=0)else(1))
    return (8)if(sp()!=0)else(9)
def _8():
    sa(sr())
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    print(sp(),end="",flush=True)
    return 13
def _9():
    global x2
    global x1
    x2=0
    sa(sp()+(1));
    sa(sr())
    sa(sr())
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    sa(sp()*(24));
    sa(sp()+(1));
    sa(sr())
    x1=sp()
    return 1
def _10():
    global x2
    global x1
    x2=0
    sp()
    sa(sp()+(1));
    sa(sr())
    sa(sr())
    sa(sp()*(2));
    sa(sp()-(1));
    sa(sp()*sp());
    sa(sp()*(24));
    sa(sp()+(1));
    sa(sr())
    x1=sp()
    return 1
def _11():
    global x2
    global x1
    global x1
    global x2
    global x2
    global x2
    sa(sr())
    sa(sp()+(x2));
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)
    x1=sp()
    sa(sr())
    sa(sp()*(2));
    sa(sp()+(x2));
    x2=sp()
    x2=td(x2,2)
    sa(td(sp(),4))
    return 3
def _12():
    global x1
    sa(td(sp(),4))
    sa(sr())
    sa((1)if(sp()>(x1))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
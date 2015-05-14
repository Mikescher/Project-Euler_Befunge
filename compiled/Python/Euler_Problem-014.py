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
x0=0
x1=32
def _0():
    sa(4)
    sa(1)
    sa(4)
    sa(0)
    return 1
def _1():
    return (11)if(sp()!=0)else(2)
def _2():
    sa(td(sp(),2))
    return 3
def _3():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(1));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(sp()-(1));
    return (10)if(sp()!=0)else(4)
def _4():
    global x0
    sp()
    sa(sr())
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (5)if(sp()!=0)else(9)
def _5():
    sp()
    return 6
def _6():
    sa(sr())
    sa((1)if(sp()>(1000000))else(0))
    sa((0)if(sp()!=0)else(1))
    return (8)if(sp()!=0)else(7)
def _7():
    global x1
    global x0
    print(x1,end="",flush=True)
    sa(x0)
    sa(58)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(sp(),end="",flush=True)
    return 12
def _8():
    sa(sp()+(1));
    sa(sr())
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(tm(sp(),2))
    return 1
def _9():
    global x0
    global x1
    x0=sp()
    sa(sr())
    x1=sp()
    return 6
def _10():
    sa(td(sp(),1))
    sa(sr())
    sa(tm(sp(),2))
    return 1
def _11():
    sa(sp()*(3));
    sa(sp()+(1));
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11]
c=0
while c<12:
    c=m[c]()
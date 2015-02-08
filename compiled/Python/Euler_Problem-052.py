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
x0=88
x1=88
x2=88
x3=88
x4=88
def _0():
    return (9)if(sp()!=0)else(2)
def _1():
    global x0
    global x3
    global x1
    x0=10
    x3=1
    x1=1
    sa(10)
    sa(1)
    sa(1)
    sa(1)
    sa(1)
    return 0
def _2():
    global x2
    global x2
    x2=2
    sp()
    sa(sr())
    sa(x2)
    return 3
def _3():
    global x4
    x4=1
    sa(sp()*sp());
    sa(sp()*(10));
    return 10
def _4():
    global x4
    global x4
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    sa(sp()*(x4));
    x4=sp()
    return 10
def _5():
    print(sp(),end="",flush=True)
    sp()
    sp()
    return 14
def _6():
    global x2
    sa(sr())
    sa(x2)
    return 3
def _7():
    global x1
    x1=1
    sa(sr())
    sa(sr())
    sa(sp()*(10));
    sa(td(sp(),10))
    sa(sr())
    return 0
def _8():
    global x0
    global x3
    global x1
    sp()
    sa(sp()*(10));
    sa(sr())
    x0=sp()
    sa(sr())
    sa(td(sp(),6))
    x3=sp()
    x1=1
    sa(sr())
    sa(td(sp(),10))
    sa(sr())
    sa(sr())
    sa(sp()*(10));
    sa(td(sp(),10))
    sa(sr())
    return 0
def _9():
    global x1
    global x1
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    sa(sp()*(x1));
    x1=sp()
    sa(td(sp(),10))
    sa(sr())
    return 0
def _10():
    sa(td(sp(),10))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (11)if(sp()!=0)else(4)
def _11():
    sp()
    return (12)if((x4)-(x1))else(13)
def _12():
    global x3
    sp()
    sa(sp()+(1));
    sa(sr())
    sa(x3)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return (8)if(sp()!=0)else(7)
def _13():
    global x2
    sa((x2)+(1))
    x2=(x2)+(1)
    sa(sp()-(7));
    return (6)if(sp()!=0)else(5)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=1
while c<14:
    c=m[c]()
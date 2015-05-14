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
x0=4818
def _0():
    sa(1488)
    sa(1800)
    sa(1800)
    return 1
def _1():
    return (14)if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))-(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))else(2)
def _2():
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (3)if(sp()!=0)else(14)
def _3():
    sa(sr())
    sa(sr())
    sa((1)if(sp()>(9999))else(0))
    return (10)if(sp()!=0)else(4)
def _4():
    sa(sr())
    sa(sr())
    sa(tm(sp(),2))
    sa((0)if(sp()!=0)else(1))
    return (13)if(sp()!=0)else(5)
def _5():
    sa(sr())
    sa(tm(sp(),3))
    sa((0)if(sp()!=0)else(1))
    return (13)if(sp()!=0)else(6)
def _6():
    global x0
    x0=sp()
    sa(7)
    sa((0)if(tm(x0,7)!=0)else(1))
    return 7
def _7():
    return (13)if(sp()!=0)else(8)
def _8():
    sa(sr())
    sa((1)if(sp()>(td(x0,2)))else(0))
    return (9)if(sp()!=0)else(11)
def _9():
    sp()
    sa(sp()+(3330));
    sa(sr())
    sa((1)if(sp()>(9999))else(0))
    return (10)if(sp()!=0)else(4)
def _10():
    sp()
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+(3330));
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+(3330));
    print(sp(),end="",flush=True)
    return 15
def _11():
    global x0
    sa(sr())
    sa(sp()-(2));
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    return (12)if(sp()!=0)else(13)
def _12():
    global x0
    sa(sp()+(6));
    sa(sr())
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 7
def _13():
    global x0
    sp()
    sp()
    sa(sp()+(1));
    sa(sr())
    sa(sr())
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sp()+(2));
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(3330));
    x0=sp()
    sa(sr())
    return 1
def _14():
    global x0
    sp()
    sp()
    sa(sp()+(1));
    sa(sr())
    sa(sr())
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    sa(tm(sp(),10))
    sa(sp()+(2));
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sp()+(2));
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+(3330));
    x0=sp()
    sa(sr())
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()
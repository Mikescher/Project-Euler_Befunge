#!/usr/bin/env python3
# compiled with BefunCompile v1.0.6 (c) 2015
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
    return (14)if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))!=(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))else(2)
def _2():
    v0=sp()
    sa(sp()-v0)
    sa((0)if(sp()!=0)else(1))
    return (3)if(sp()!=0)else(14)
def _3():
    sa(sr())
    return (11)if(sr()>9999)else(4)
def _4():
    sa(sr())
    return (5)if(tm(sr(),2)==0)else(6)
def _5():
    global x0
    sp()
    sp()
    sa(sp()+1);
    sa(sr())
    sa(sr())
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sp()+2);
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330);
    x0=sp()
    sa(sr())
    return 1
def _6():
    return (5)if(tm(sr(),3)==0)else(7)
def _7():
    global x0
    x0=sp()
    sa(7)
    sa((0)if(tm(x0,7)!=0)else(1))
    return 8
def _8():
    return (5)if(sp()!=0)else(9)
def _9():
    return (10)if(sr()>td(x0,2))else(12)
def _10():
    sp()
    sa(sp()+3330);
    return (11)if(sr()>9999)else(4)
def _11():
    sp()
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+3330);
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(32),end="",flush=True)
    sa(sp()+3330);
    print(sp(),end="",flush=True)
    return 15
def _12():
    global x0
    sa(sr()-2)
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    return (13)if(sp()!=0)else(5)
def _13():
    global x0
    sa(sp()+6);
    sa(sr())
    sa(x0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 8
def _14():
    global x0
    sp()
    sp()
    sa(sp()+1);
    sa(sr())
    sa(sr())
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa((tm(sr(),10))+2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sp()+2);
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330);
    x0=sp()
    sa(sr())
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()
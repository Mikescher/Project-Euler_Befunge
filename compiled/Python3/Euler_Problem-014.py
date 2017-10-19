#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
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
    sa(sp()/2);
    return 3
def _3():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+1)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (10)if(sr()!=1)else(4)
def _4():
    global x0
    sp();

    return (5)if(sr()<x0)else(9)
def _5():
    sp();
    return 6
def _6():
    return (7)if(sr()>1000000)else(8)
def _7():
    global x1
    global x0
    print(x1,end=" ",flush=True)
    print(" :",end="",flush=True)
    print(x0,end=" ",flush=True)
    return 12
def _8():
    sa(sp()+1)

    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()%2)
    return 1
def _9():
    global x0
    global x1
    x0=sp()
    x1=sr()
    return 6
def _10():
    sa(sp()/1);

    sa(sr()%2)
    return 1
def _11():
    sa(sp()*3)

    sa(sp()+1)
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11]
c=0
while c<12:
    c=m[c]()

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
x0=1
x1=1
x2=99
x3=99
x4=32
def _0():
    return 1
def _1():
    global x3
    global x2
    return (8)if(x3>x2)else(2)
def _2():
    global t0
    global x2
    t0=x2-10
    x2=x2-1

    return (7)if((t0)!=0)else(3)
def _3():
    global x0
    global x1
    sp();
    sa(x0)
    sa(x1)

    return (5)if((x1)!=0)else(4)
def _4():
    global x1
    sp();
    sa(x1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))

    print(sp(),end=" ",flush=True)
    return 22
def _5():
    global x4
    x4=sr()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),x4))

    sa(sr());
    return 6
def _6():
    return (5)if(sp()!=0)else(4)
def _7():
    global x3
    x3=99
    return 1
def _8():
    global x2
    return (20)if((x2/10)!=0)else(9)
def _9():
    global x2
    return (18)if((x2/10)!=0)else(10)
def _10():
    global x2
    return (16)if((x2%10)!=0)else(11)
def _11():
    global x2
    return (13)if((x2%10)!=0)else(12)
def _12():
    global t0
    global x3
    t0=x3-10
    x3=x3-1

    return (1)if((t0)!=0)else(2)
def _13():
    global x2
    global x3
    return (12)if(((x2%10)-(x3%10))!=0)else(14)
def _14():
    global x2
    global x3
    return (12)if(((x2*(x3%10))-(x3*(x2%10)))!=0)else(15)
def _15():
    global x0
    global x2
    global x1
    global x3
    x0=x0*x2
    x1=x1*x3
    return 12
def _16():
    global x2
    global x3
    return (11)if(((x2%10)-(x3/10))!=0)else(17)
def _17():
    global x2
    global x3
    return (11)if(((x2*(x3%10))-(x3*(x2/10)))!=0)else(15)
def _18():
    global x2
    global x3
    return (10)if(((x2/10)-(x3%10))!=0)else(19)
def _19():
    global x2
    global x3
    return (10)if(((x2*(x3/10))-(x3*(x2%10)))!=0)else(15)
def _20():
    global x2
    global x3
    return (9)if(((x2/10)-(x3/10))!=0)else(21)
def _21():
    global x2
    global x3
    return (9)if(((x2*(x3/10))-(x3*(x2/10)))!=0)else(15)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21]
c=0
while c<22:
    c=m[c]()

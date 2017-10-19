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
x1=1
x2=88
x3=1
x4=88
def _0():
    sa(10)
    sa(1)
    sa(1)
    sa(1)
    sa(1)
    return 1
def _1():
    return (12)if(sp()!=0)else(2)
def _2():
    global x2
    global x4
    x2=2
    sp();
    sa((sr()*x2*10)/10)
    x4=1
    return 3
def _3():
    sa(sr());

    return (11)if(sp()!=0)else(4)
def _4():
    global x4
    global x1
    sp();

    return (8)if((x4-x1)!=0)else(5)
def _5():
    global t0
    global x2
    t0=x2-6
    x2=x2+1

    return (7)if((t0)!=0)else(6)
def _6():
    print(sp(),end=" ",flush=True)
    sp();
    sp();
    return 13
def _7():
    global x2
    global x4
    sa((sr()*x2*10)/10)
    x4=1
    return 3
def _8():
    global x3
    sp();
    sa(sp()+1)


    return (10)if(sr()<x3)else(9)
def _9():
    global t0
    global x3
    global x1
    sp();
    sa(sp()*10)

    t0=sr()/6
    x3=t0
    x1=1
    sa(sr()/10)
    sa(sr());
    sa((sr()*10)/10)
    sa(sr());
    return 1
def _10():
    global x1
    x1=1
    sa(sr());
    sa((sr()*10)/10)
    sa(sr());
    return 1
def _11():
    global t0
    global x4
    t0=((sr()%10)+2)*x4
    x4=t0
    sa(sp()/10);
    return 3
def _12():
    global t0
    global x1
    t0=((sr()%10)+2)*x1
    x1=t0
    sa(sp()/10);

    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()

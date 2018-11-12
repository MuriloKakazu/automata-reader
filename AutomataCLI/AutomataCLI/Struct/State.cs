﻿using System;
using System.Collections.Generic;

namespace AutomataCLI.Struct {
    public class State {
        public String Name { get; protected set; }
        public Boolean IsFinal { get; protected set; }

        public static State Empty
            => new State("Empty");

        public State(String name, Boolean isFinal = false) {
            this.Name    = name.Trim();
            this.IsFinal = isFinal;
        }

        public override String ToString()
          //=> $"{Name} <{(IsFinal ? "Final" : "Not Final")}>";
            => $"{Name}";
    }
}
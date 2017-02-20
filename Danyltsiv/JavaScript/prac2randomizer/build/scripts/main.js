(function e(t,n,r){function s(o,u){if(!n[o]){if(!t[o]){var a=typeof require=="function"&&require;if(!u&&a)return a(o,!0);if(i)return i(o,!0);var f=new Error("Cannot find module '"+o+"'");throw f.code="MODULE_NOT_FOUND",f}var l=n[o]={exports:{}};t[o][0].call(l.exports,function(e){var n=t[o][1][e];return s(n?n:e)},l,l.exports,e,t,n,r)}return n[o].exports}var i=typeof require=="function"&&require;for(var o=0;o<r.length;o++)s(r[o]);return s})({1:[function(require,module,exports){
"use strict";

Object.defineProperty(exports, "__esModule", {
    value: true
});

exports.default = function (draw, duration) {
    var start = performance.now();

    requestAnimationFrame(function animate(time) {
        var timePassed = time - start;
        if (timePassed > duration) timePassed = duration;
        draw(timePassed);

        if (timePassed < duration) {
            requestAnimationFrame(animate);
        }
    });
};

},{}],2:[function(require,module,exports){
'use strict';

var _random = require('./random');

var _random2 = _interopRequireDefault(_random);

var _animation = require('./animation');

var _animation2 = _interopRequireDefault(_animation);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var goBtn = document.getElementById('goBtn');
var number = document.getElementById('number');
var clrBtn = document.getElementById('clrBtn');
var unique = document.getElementById('unique');

goBtn.onclick = function () {
  var rnd = void 0;
  var numbers = [];
  var i = 0;
  for (var a in localStorage) {
    numbers[i] = parseInt(localStorage[a]);
    i++;
  }

  if ((0, _random2.default)(parseInt(from.value), parseInt(to.value), numbers) != false) {

    (0, _animation2.default)(function (timePassed) {
      if (!unique.checked) {
        rnd = (0, _random2.default)(parseInt(from.value), parseInt(to.value));
      } else {
        rnd = (0, _random2.default)(parseInt(from.value), parseInt(to.value), numbers);
      }
      number.innerHTML = rnd;
      var fontSizeAnim = timePassed / 20;
      number.style.fontSize = fontSizeAnim + 'px';
    }, 4000);

    if (!unique.disabled) setTimeout(function () {
      if (rnd != undefined) {
        localStorage.setItem(localStorage.length, rnd);
      }
    }, 4100);
  } else {
    number.innerHTML = "<p class='error'>No more unique numbers! Reset the local storage please!</p>";
  }
};

clrBtn.onclick = function () {
  localStorage.clear();
  number.innerHTML = "<p class='reseted'>Local Storage reseted succesfully!</p>";
};

unique.onclick = function () {
  localStorage.clear();
  clrBtn.disabled = !unique.checked;
};

},{"./animation":1,"./random":3}],3:[function(require,module,exports){
"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});

exports.default = function (from, to, except) {
  var random = Math.floor(Math.random() * (to - from + 1)) + from;

  if (except !== undefined && except.length - 1 >= to - from) return false;

  while (except !== undefined && except.length !== 0 && except.includes(random)) {
    random = Math.floor(Math.random() * (to - from + 1)) + from;
  }

  return random;
};

;

},{}]},{},[2]);

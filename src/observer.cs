using System;
using System.Collections;
using System.Collections.Generic;

namespace design_patterns_cs
{
    public interface Observer {
        // 데이터 변경을 통보했을 때 처리하는 메서드
        void update();
    }

    /* 추상화된 변경 관심 대상 데이터 */
    // 즉, 데이터에 공통적으로 들어가야하는 메서드들 -> 일반화
    public abstract class Subject {
        // 추상화된 통보 대상 목록 (즉, 출력 형태에 대한 Observer)
        private List<Observer> observers = new List<Observer>();

        // 통보 대상(Observer) 추가
        public void attach(Observer observer) { observers.Add(observer);}
        // 통보 대상(Observer) 제거
        public void detach(Observer observer) { observers.Remove(observer);}
        // 각 통보 대상(Observer)에 변경을 통보. (List<Observer>객체들의 update를 호출)
        public void notifyObservers() {
            foreach(Observer o in observers) {
                o.update();
            }
        }
    }

    /* 구체적인 변경 감시 대상 데이터 */
    // 출력형태 2개를 가질 때
    public class ScoreRecord : Subject{
        private List<int> scores = new List<int>(); // 점수를 저장함
        // 새로운 점수를 추가 (상태 변경)
        public void addScore(int score) {
            scores.Add(score); // scores 목록에 주어진 점수를 추가함
            notifyObservers(); // scores가 변경됨을 각 통보 대상(Observer)에게 통보함
        }
        public List<int> getScoreRecord() { return scores; }
    }

    /* 통보 대상 클래스 (update 메서드 구현) */
    // 2. 출력형태: 최대값 최소값만 출력하는 클래스    

    public class MinMaxView : Observer{
        private ScoreRecord scoreRecord;
        // getScoreRecord()를 호출하기 위해 ScoreRecord 객체를 인자로 받음
        public MinMaxView(ScoreRecord scoreRecord) {
            this.scoreRecord = scoreRecord;
        }

        // 점수의 변경을 통보받음
        public void update() {
            List<int> record = scoreRecord.getScoreRecord(); // 점수를 조회함
            displayScores(record); // 최소값과 최대값을 출력함
        }
        // 최소값과 최대값을 출력함
        private void displayScores(List<int> record) {
            int min = 1; //Collections.min(record, null);
            int max = 5; //Collections.max(record, null);
            Console.WriteLine("Min: " + min + ", Max: " + max);
            
        }
    }

    public class DataSheetView {
        private ScoreRecord scoreRecord;
        private int viewCount;

        public DataSheetView(ScoreRecord scoreRecord, int viewCount) {
            this.scoreRecord = scoreRecord;
            this.viewCount = viewCount;
        }

        // 점수의 변경을 통보받음
        public void update() {
            List<int> record = scoreRecord.getScoreRecord(); // 점수를 조회함
            displayScores(record, viewCount); // 조회된 점수를 viewCount 만큼만 출력함
        }

        private void displayScores(List<int> record, int viewCount) {
            Console.WriteLine("List of " + viewCount + " entries: ");
            foreach(var value in record)
            {
                Console.WriteLine(value + " ");
            }
            
            Console.WriteLine();
        }
    }

}
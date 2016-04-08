using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    static class PlayerData
    {
        /// <summary>
        /// First trait, and first question
        /// </summary>
        static private string firstTrait        = "lives in water";

        /// <summary>
        /// String of the first animal that lives in water
        /// </summary>
        static private string firstYes          = "shark";

        /// <summary>
        /// String of the first animal that does not live in water
        /// </summary>
        static private string firstNo           = "monkey";

        /// <summary>
        /// Binary tree to hold all the data and build up the game
        /// </summary>
        static private Question questionTree    = new Question(firstTrait, new Question(firstYes), new Question(firstNo));

        /// <summary>
        /// Last visited node of the tree
        /// </summary>
        static private Question lastQuestion    = questionTree;

        /// <summary>
        /// Current question, the selected node of the tree
        /// </summary>
        static private Question currentQuestion = questionTree;

        /// <summary>
        /// Last animal name, to show to the player
        /// </summary>
        static public string lastAnimal         = "";

        /// <summary>
        /// New animal entered by the player
        /// </summary>
        static public string newAnimal          = "";

        /// <summary>
        /// Adds a new question node to the tree
        /// </summary>
        /// <param name="trait">Trait's name</param>
        /// <param name="animal">Animal's name</param>
        static public void AddQuestion(string trait, string animal)
        {
            lastQuestion.Change(trait, animal);
            currentQuestion = questionTree;
        }

        /// <summary>
        /// Gets the current question
        /// </summary>
        /// <returns>The current question</returns>
        static public Question CurrentQuestion()
        {
            return currentQuestion;
        }

        /// <summary>
        /// Gets the current question's total description
        /// </summary>
        /// <returns>The description</returns>
        static public string CurrentDescription()
        {
            if (CurrentQuestion() != null)
            {
                return currentQuestion.GetTotalDescription();
            }
            return "";
        }

        /// <summary>
        /// Gets the current question type
        /// </summary>
        /// <returns>The current question type</returns>
        static public Question.Type CurrentQuestionType()
        {
            if (CurrentQuestion() != null)
            {
                return currentQuestion.GetQuestionType();
            }
            return Question.Type.Animal;
        }

        /// <summary>
        /// Answer the current question, and makes it goes down in the tree
        /// </summary>
        /// <param name="yes">Yes to go down in the left side, no to go right. Yes and no questions</param>
        static public void AnswerQuestion(bool yes)
        {
            if (CurrentQuestion() != null)
            {
                lastQuestion = currentQuestion;
                currentQuestion = currentQuestion.Answer(yes);
            }
        }

        /// <summary>
        /// Returns the current question to the root of the tree
        /// </summary>
        static public void ResetCurrentQuestion()
        {
            currentQuestion = questionTree;
        }
    }


    public class Question
    {
        /// <summary>
        /// The '?', to build up the complete description.
        /// </summary>
        private const string QUESTION_MARK      = "?";

        /// <summary>
        /// The question if this object is a trait, to build up the complete description.
        /// </summary>
        private const string TRAIT_QUESTION     = "Does the animal that you thought about ";

        /// <summary>
        /// The question if this object is an animal, to build up the complete description.
        /// </summary>
        private const string ANIMAL_QUESTION    = "Is the animal that you thought about a ";

        /// <summary>
        /// Question types
        /// </summary>
        public enum Type
        {
            Trait, Animal
        }

        /// <summary>
        /// The yes question, left node of the tree
        /// </summary>
        private Question questionYes            = null;

        /// <summary>
        /// The no question, right node of the tree
        /// </summary>
        private Question questionNo             = null;

        /// <summary>
        /// The trait or animal name
        /// </summary>
        private string description;

        /// <summary>
        /// Type, trait or animal
        /// </summary>
        private Type type;

        /// <summary>
        /// Creates an animal. It has no Questions attached, it's the tree leaves.
        /// </summary>
        /// <param name="description">The animal name</param>
        public Question(string description)
        {
            this.description    = description;
            this.type           = Type.Animal;
        }

        /// <summary>
        /// Creates a trait, and place it's answers, yes and no (animals)
        /// </summary>
        /// <param name="description">Name of the trait, like 'lives in water'</param>
        /// <param name="questionYes">The animal if the player choses yes</param>
        /// <param name="questionNo">The animal if the player choses no</param>
        public Question(string description, Question questionYes, Question questionNo)
        {
            this.description    = description;
            this.questionYes    = questionYes;
            this.questionNo     = questionNo;
            this.type           = Type.Trait;
        }

        /// <summary>
        /// A description to be shown to the player, trait or animal, and the correct name.
        /// </summary>
        /// <returns>The full description</returns>
        public string GetTotalDescription()
        {
            if (this.type == Type.Animal)
            { 
                return ANIMAL_QUESTION + this.description + QUESTION_MARK;
            }
            return TRAIT_QUESTION + this.description + QUESTION_MARK;
        }

        /// <summary>
        /// Returns the Question type
        /// </summary>
        /// <returns>The type</returns>
        public Type GetQuestionType()
        {
            return this.type;
        }

        /// <summary>
        /// Change the actual Question, and the node of the tree, so that the yes question points to the new animal, and the no question points to the old animal. The current Question is now a trait.
        /// </summary>
        /// <param name="trait"></param>
        /// <param name="animal"></param>
        public void Change(string trait, string animal)
        {
            string oldDescription   = this.description;
            this.description        = trait;
            this.questionYes        = new Question(animal);
            this.questionNo         = new Question(oldDescription);
        }

        /// <summary>
        /// Returns the desired Question that the player's answer gives, yes or no.
        /// </summary>
        /// <param name="yes">true for yes Question, false for no Question</param>
        /// <returns>The desired Question</returns>
        public Question Answer(bool yes)
        {
            if (yes)
            {
                return this.questionYes;
            }
            return this.questionNo;
        }

        /// <summary>
        /// Descrition of the trait or animal name
        /// </summary>
        /// <returns>The description</returns>
        public string GetDescription()
        {
            return description;
        }
    }
}

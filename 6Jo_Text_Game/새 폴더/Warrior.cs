namespace Chapter4
{
        public class Warrior : ICharacter
        {
                public Action<float> ChangedCallback;

                private float _health;
                public float Health
                {
                        get { return _health; }
                        set
                        {
                                _health = value;
                                ChangedCallback?.Invoke(_health);
                        }
                }
                public float Attack { get; set; }
                public string Name { get; set; }
                public float Speed { get; set; }
                public bool IsDead { get; set; }
                public void TakeDamage(float damage)
                {
                        Health -= damage;
                }
                public void SetChangedCallback(Action<float> callback)
                {
                        ChangedCallback = callback;
                }

        }
}
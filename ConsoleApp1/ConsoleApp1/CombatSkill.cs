namespace HomeWork;

public interface CombatSkill
{
    string getName();
    void use(int damage, Base pl1, Base pl2, int defense);
}
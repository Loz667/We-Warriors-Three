// Copyright Loren Penny


#include "WarriorsCharacterBase.h"

// Sets default values
AWarriorsCharacterBase::AWarriorsCharacterBase()
{
 	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AWarriorsCharacterBase::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AWarriorsCharacterBase::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AWarriorsCharacterBase::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}


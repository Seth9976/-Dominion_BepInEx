using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000052 RID: 82
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x00028338 File Offset: 0x00026538
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAnimator()
		{
			Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr);
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_animations");
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_TextComponent");
			TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664220);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664221);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664222);
			TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664223);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664224);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664225);
			TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664226);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0002841C File Offset: 0x0002661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144909, XrefRangeEnd = 144912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00028450 File Offset: 0x00026650
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00028484 File Offset: 0x00026684
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000284B8 File Offset: 0x000266B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144917, RefRangeEnd = 144919, XrefRangeStart = 144912, XrefRangeEnd = 144917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000284EC File Offset: 0x000266EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144919, XrefRangeEnd = 144930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00028568 File Offset: 0x00026768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144930, XrefRangeEnd = 144934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000285F0 File Offset: 0x000267F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144934, XrefRangeEnd = 144941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000065F8 File Offset: 0x000047F8
		public TMP_SpriteAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0002862C File Offset: 0x0002682C
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00006601 File Offset: 0x00004801
		public unsafe Dictionary<int, bool> m_animations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0002865C File Offset: 0x0002685C
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00006620 File Offset: 0x00004820
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_m_animations;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_StopAllAnimations_Public_Void_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("TMPro.TMP_SpriteAnimator+<DoSpriteAnimationInternal>d__7")]
		public sealed class _DoSpriteAnimationInternal_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FB9 RID: 4025 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSpriteAnimationInternal_d__7()
			{
				Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "<DoSpriteAnimationInternal>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>1__state");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>2__current");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>4__this");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "start");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "end");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "spriteAsset");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "currentCharacter");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "framerate");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<currentFrame>5__2");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<charInfo>5__3");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<materialIndex>5__4");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<vertexIndex>5__5");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<meshInfo>5__6");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<baseSpriteScale>5__7");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<elapsedTime>5__8");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<targetTime>5__9");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664889);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664890);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664891);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664892);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664893);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664894);
			}

			// Token: 0x06000FBA RID: 4026 RVA: 0x0003E5BC File Offset: 0x0003C7BC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSpriteAnimationInternal_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FBB RID: 4027 RVA: 0x0003E604 File Offset: 0x0003C804
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FBC RID: 4028 RVA: 0x0003E638 File Offset: 0x0003C838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144860, XrefRangeEnd = 144904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06000FBD RID: 4029 RVA: 0x0003E674 File Offset: 0x0003C874
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FBE RID: 4030 RVA: 0x0003E6B4 File Offset: 0x0003C8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144904, XrefRangeEnd = 144909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FC0 RID: 4032 RVA: 0x0000979F File Offset: 0x0000799F
			public _DoSpriteAnimationInternal_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0003E728 File Offset: 0x0003C928
			// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x000097A8 File Offset: 0x000079A8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x0003E750 File Offset: 0x0003C950
			// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000097C3 File Offset: 0x000079C3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0003E780 File Offset: 0x0003C980
			// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000097E2 File Offset: 0x000079E2
			public unsafe TMP_SpriteAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0003E7B0 File Offset: 0x0003C9B0
			// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00009801 File Offset: 0x00007A01
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0003E7D8 File Offset: 0x0003C9D8
			// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0000981C File Offset: 0x00007A1C
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0003E800 File Offset: 0x0003CA00
			// (set) Token: 0x06000FCC RID: 4044 RVA: 0x00009837 File Offset: 0x00007A37
			public unsafe TMP_SpriteAsset spriteAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0003E830 File Offset: 0x0003CA30
			// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00009856 File Offset: 0x00007A56
			public unsafe int currentCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter)) = value;
				}
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0003E858 File Offset: 0x0003CA58
			// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00009871 File Offset: 0x00007A71
			public unsafe int framerate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate)) = value;
				}
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0003E880 File Offset: 0x0003CA80
			// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0000988C File Offset: 0x00007A8C
			public unsafe int _currentFrame_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2)) = value;
				}
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
			// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000098A7 File Offset: 0x00007AA7
			public TMP_CharacterInfo _charInfo_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3);
					return new TMP_CharacterInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
			// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000098D5 File Offset: 0x00007AD5
			public unsafe int _materialIndex_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4)) = value;
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0003E900 File Offset: 0x0003CB00
			// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000098F0 File Offset: 0x00007AF0
			public unsafe int _vertexIndex_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5)) = value;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0003E928 File Offset: 0x0003CB28
			// (set) Token: 0x06000FDA RID: 4058 RVA: 0x0000990B File Offset: 0x00007B0B
			public TMP_MeshInfo _meshInfo_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6);
					return new TMP_MeshInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06000FDB RID: 4059 RVA: 0x0003E958 File Offset: 0x0003CB58
			// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00009939 File Offset: 0x00007B39
			public unsafe float _baseSpriteScale_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7)) = value;
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0003E980 File Offset: 0x0003CB80
			// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00009954 File Offset: 0x00007B54
			public unsafe float _elapsedTime_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8)) = value;
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0003E9A8 File Offset: 0x0003CBA8
			// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0000996F File Offset: 0x00007B6F
			public unsafe float _targetTime_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9)) = value;
				}
			}

			// Token: 0x04000C5A RID: 3162
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C5B RID: 3163
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C5C RID: 3164
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C5D RID: 3165
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04000C5E RID: 3166
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04000C5F RID: 3167
			private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

			// Token: 0x04000C60 RID: 3168
			private static readonly IntPtr NativeFieldInfoPtr_currentCharacter;

			// Token: 0x04000C61 RID: 3169
			private static readonly IntPtr NativeFieldInfoPtr_framerate;

			// Token: 0x04000C62 RID: 3170
			private static readonly IntPtr NativeFieldInfoPtr__currentFrame_5__2;

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeFieldInfoPtr__charInfo_5__3;

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr__materialIndex_5__4;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeFieldInfoPtr__vertexIndex_5__5;

			// Token: 0x04000C66 RID: 3174
			private static readonly IntPtr NativeFieldInfoPtr__meshInfo_5__6;

			// Token: 0x04000C67 RID: 3175
			private static readonly IntPtr NativeFieldInfoPtr__baseSpriteScale_5__7;

			// Token: 0x04000C68 RID: 3176
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__8;

			// Token: 0x04000C69 RID: 3177
			private static readonly IntPtr NativeFieldInfoPtr__targetTime_5__9;

			// Token: 0x04000C6A RID: 3178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C6B RID: 3179
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C6C RID: 3180
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000108 RID: 264
	public class TextConsoleSimulator : MonoBehaviour
	{
		// Token: 0x06001F1C RID: 7964 RVA: 0x00078FAC File Offset: 0x000771AC
		// Note: this type is marked as 'beforefieldinit'.
		static TextConsoleSimulator()
		{
			Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TextConsoleSimulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr);
			TextConsoleSimulator.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, "m_TextComponent");
			TextConsoleSimulator.NativeFieldInfoPtr_hasTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, "hasTextChanged");
			TextConsoleSimulator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665841);
			TextConsoleSimulator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665842);
			TextConsoleSimulator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665843);
			TextConsoleSimulator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665844);
			TextConsoleSimulator.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665845);
			TextConsoleSimulator.NativeMethodInfoPtr_RevealCharacters_Private_IEnumerator_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665846);
			TextConsoleSimulator.NativeMethodInfoPtr_RevealWords_Private_IEnumerator_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665847);
			TextConsoleSimulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, 100665848);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000790A4 File Offset: 0x000772A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256118, XrefRangeEnd = 256122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000790D8 File Offset: 0x000772D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256122, XrefRangeEnd = 256128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0007910C File Offset: 0x0007730C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256128, XrefRangeEnd = 256144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00079140 File Offset: 0x00077340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256144, XrefRangeEnd = 256160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00079174 File Offset: 0x00077374
		[CallerCount(0)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x000791B8 File Offset: 0x000773B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256160, XrefRangeEnd = 256164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_RevealCharacters_Private_IEnumerator_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00079208 File Offset: 0x00077408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256164, XrefRangeEnd = 256168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RevealWords(TMP_Text textComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr_RevealWords_Private_IEnumerator_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00079258 File Offset: 0x00077458
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextConsoleSimulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0001369B File Offset: 0x0001189B
		public TextConsoleSimulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00079294 File Offset: 0x00077494
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x000136A4 File Offset: 0x000118A4
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x000792C4 File Offset: 0x000774C4
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x000136C3 File Offset: 0x000118C3
		public unsafe bool hasTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator.NativeFieldInfoPtr_hasTextChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator.NativeFieldInfoPtr_hasTextChanged)) = value;
			}
		}

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_hasTextChanged;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_RevealCharacters_Private_IEnumerator_TMP_Text_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_RevealWords_Private_IEnumerator_TMP_Text_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000229 RID: 553
		[ObfuscatedName("TMPro.Examples.TextConsoleSimulator+<RevealCharacters>d__7")]
		public sealed class _RevealCharacters_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002AB3 RID: 10931 RVA: 0x00098E84 File Offset: 0x00097084
			// Note: this type is marked as 'beforefieldinit'.
			static _RevealCharacters_d__7()
			{
				Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, "<RevealCharacters>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr);
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<>1__state");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<>2__current");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "textComponent");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<>4__this");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<textInfo>5__2");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__totalVisibleCharacters_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<totalVisibleCharacters>5__3");
				TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__visibleCount_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, "<visibleCount>5__4");
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666665);
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666666);
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666667);
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666668);
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666669);
				TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr, 100666670);
			}

			// Token: 0x06002AB4 RID: 10932 RVA: 0x00098FB4 File Offset: 0x000971B4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RevealCharacters_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextConsoleSimulator._RevealCharacters_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AB5 RID: 10933 RVA: 0x00098FFC File Offset: 0x000971FC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AB6 RID: 10934 RVA: 0x00099030 File Offset: 0x00097230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256106, XrefRangeEnd = 256107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0009906C File Offset: 0x0009726C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000990AC File Offset: 0x000972AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256107, XrefRangeEnd = 256112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000990E0 File Offset: 0x000972E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealCharacters_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x0001A345 File Offset: 0x00018545
			public _RevealCharacters_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x06002ABB RID: 10939 RVA: 0x00099120 File Offset: 0x00097320
			// (set) Token: 0x06002ABC RID: 10940 RVA: 0x0001A34E File Offset: 0x0001854E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x06002ABD RID: 10941 RVA: 0x00099148 File Offset: 0x00097348
			// (set) Token: 0x06002ABE RID: 10942 RVA: 0x0001A369 File Offset: 0x00018569
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x06002ABF RID: 10943 RVA: 0x00099178 File Offset: 0x00097378
			// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0001A388 File Offset: 0x00018588
			public unsafe TMP_Text textComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr_textComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000991A8 File Offset: 0x000973A8
			// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0001A3A7 File Offset: 0x000185A7
			public unsafe TextConsoleSimulator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextConsoleSimulator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000991D8 File Offset: 0x000973D8
			// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0001A3C6 File Offset: 0x000185C6
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x00099208 File Offset: 0x00097408
			// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0001A3E5 File Offset: 0x000185E5
			public unsafe int _totalVisibleCharacters_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__totalVisibleCharacters_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__totalVisibleCharacters_5__3)) = value;
				}
			}

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x00099230 File Offset: 0x00097430
			// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0001A400 File Offset: 0x00018600
			public unsafe int _visibleCount_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__visibleCount_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealCharacters_d__7.NativeFieldInfoPtr__visibleCount_5__4)) = value;
				}
			}

			// Token: 0x04001D31 RID: 7473
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D32 RID: 7474
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D33 RID: 7475
			private static readonly IntPtr NativeFieldInfoPtr_textComponent;

			// Token: 0x04001D34 RID: 7476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D35 RID: 7477
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001D36 RID: 7478
			private static readonly IntPtr NativeFieldInfoPtr__totalVisibleCharacters_5__3;

			// Token: 0x04001D37 RID: 7479
			private static readonly IntPtr NativeFieldInfoPtr__visibleCount_5__4;

			// Token: 0x04001D38 RID: 7480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D39 RID: 7481
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D3A RID: 7482
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D3B RID: 7483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D3C RID: 7484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D3D RID: 7485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200022A RID: 554
		[ObfuscatedName("TMPro.Examples.TextConsoleSimulator+<RevealWords>d__8")]
		public sealed class _RevealWords_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06002AC9 RID: 10953 RVA: 0x00099258 File Offset: 0x00097458
			// Note: this type is marked as 'beforefieldinit'.
			static _RevealWords_d__8()
			{
				Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextConsoleSimulator>.NativeClassPtr, "<RevealWords>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr);
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<>1__state");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<>2__current");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr_textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "textComponent");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalWordCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<totalWordCount>5__2");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalVisibleCharacters_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<totalVisibleCharacters>5__3");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__counter_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<counter>5__4");
				TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__visibleCount_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, "<visibleCount>5__5");
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666671);
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666672);
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666673);
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666674);
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666675);
				TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr, 100666676);
			}

			// Token: 0x06002ACA RID: 10954 RVA: 0x00099388 File Offset: 0x00097588
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RevealWords_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextConsoleSimulator._RevealWords_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ACB RID: 10955 RVA: 0x000993D0 File Offset: 0x000975D0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ACC RID: 10956 RVA: 0x00099404 File Offset: 0x00097604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256112, XrefRangeEnd = 256113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x06002ACD RID: 10957 RVA: 0x00099440 File Offset: 0x00097640
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002ACE RID: 10958 RVA: 0x00099480 File Offset: 0x00097680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256113, XrefRangeEnd = 256118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06002ACF RID: 10959 RVA: 0x000994B4 File Offset: 0x000976B4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextConsoleSimulator._RevealWords_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AD0 RID: 10960 RVA: 0x0001A41B File Offset: 0x0001861B
			public _RevealWords_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000994F4 File Offset: 0x000976F4
			// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0001A424 File Offset: 0x00018624
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0009951C File Offset: 0x0009771C
			// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0001A43F File Offset: 0x0001863F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x0009954C File Offset: 0x0009774C
			// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0001A45E File Offset: 0x0001865E
			public unsafe TMP_Text textComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr_textComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr_textComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0009957C File Offset: 0x0009777C
			// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0001A47D File Offset: 0x0001867D
			public unsafe int _totalWordCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalWordCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalWordCount_5__2)) = value;
				}
			}

			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x000995A4 File Offset: 0x000977A4
			// (set) Token: 0x06002ADA RID: 10970 RVA: 0x0001A498 File Offset: 0x00018698
			public unsafe int _totalVisibleCharacters_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalVisibleCharacters_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__totalVisibleCharacters_5__3)) = value;
				}
			}

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000995CC File Offset: 0x000977CC
			// (set) Token: 0x06002ADC RID: 10972 RVA: 0x0001A4B3 File Offset: 0x000186B3
			public unsafe int _counter_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__counter_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__counter_5__4)) = value;
				}
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000995F4 File Offset: 0x000977F4
			// (set) Token: 0x06002ADE RID: 10974 RVA: 0x0001A4CE File Offset: 0x000186CE
			public unsafe int _visibleCount_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__visibleCount_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextConsoleSimulator._RevealWords_d__8.NativeFieldInfoPtr__visibleCount_5__5)) = value;
				}
			}

			// Token: 0x04001D3E RID: 7486
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D3F RID: 7487
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D40 RID: 7488
			private static readonly IntPtr NativeFieldInfoPtr_textComponent;

			// Token: 0x04001D41 RID: 7489
			private static readonly IntPtr NativeFieldInfoPtr__totalWordCount_5__2;

			// Token: 0x04001D42 RID: 7490
			private static readonly IntPtr NativeFieldInfoPtr__totalVisibleCharacters_5__3;

			// Token: 0x04001D43 RID: 7491
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__4;

			// Token: 0x04001D44 RID: 7492
			private static readonly IntPtr NativeFieldInfoPtr__visibleCount_5__5;

			// Token: 0x04001D45 RID: 7493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D46 RID: 7494
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D47 RID: 7495
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D48 RID: 7496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D49 RID: 7497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D4A RID: 7498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

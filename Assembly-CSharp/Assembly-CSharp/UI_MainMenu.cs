using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x020000D2 RID: 210
public class UI_MainMenu : MonoBehaviour
{
	// Token: 0x0600197E RID: 6526 RVA: 0x000668F0 File Offset: 0x00064AF0
	// Note: this type is marked as 'beforefieldinit'.
	static UI_MainMenu()
	{
		Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_MainMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr);
		UI_MainMenu.NativeFieldInfoPtr_m_QuitGameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, "m_QuitGameButton");
		UI_MainMenu.NativeFieldInfoPtr_m_themeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, "m_themeManager");
		UI_MainMenu.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665305);
		UI_MainMenu.NativeMethodInfoPtr_CheckThemeManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665306);
		UI_MainMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665307);
		UI_MainMenu.NativeMethodInfoPtr_OnNavPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665308);
		UI_MainMenu.NativeMethodInfoPtr_OnExitButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665309);
		UI_MainMenu.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665310);
		UI_MainMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, 100665311);
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x000669D4 File Offset: 0x00064BD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250413, XrefRangeEnd = 250414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x00066A08 File Offset: 0x00064C08
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 250427, RefRangeEnd = 250430, XrefRangeStart = 250414, XrefRangeEnd = 250427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckThemeManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_CheckThemeManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x00066A3C File Offset: 0x00064C3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250430, XrefRangeEnd = 250444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00066A70 File Offset: 0x00064C70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250444, XrefRangeEnd = 250450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNavPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_OnNavPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x00066AA4 File Offset: 0x00064CA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250450, XrefRangeEnd = 250451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_OnExitButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x00066AD8 File Offset: 0x00064CD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250451, XrefRangeEnd = 250455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleSoakTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00066B18 File Offset: 0x00064D18
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_MainMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x0001070A File Offset: 0x0000E90A
	public UI_MainMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000829 RID: 2089
	// (get) Token: 0x06001987 RID: 6535 RVA: 0x00066B54 File Offset: 0x00064D54
	// (set) Token: 0x06001988 RID: 6536 RVA: 0x00010713 File Offset: 0x0000E913
	public unsafe GameObject m_QuitGameButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu.NativeFieldInfoPtr_m_QuitGameButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu.NativeFieldInfoPtr_m_QuitGameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x06001989 RID: 6537 RVA: 0x00066B84 File Offset: 0x00064D84
	// (set) Token: 0x0600198A RID: 6538 RVA: 0x00010732 File Offset: 0x0000E932
	public unsafe ThemeManager m_themeManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu.NativeFieldInfoPtr_m_themeManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu.NativeFieldInfoPtr_m_themeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001154 RID: 4436
	private static readonly IntPtr NativeFieldInfoPtr_m_QuitGameButton;

	// Token: 0x04001155 RID: 4437
	private static readonly IntPtr NativeFieldInfoPtr_m_themeManager;

	// Token: 0x04001156 RID: 4438
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x04001157 RID: 4439
	private static readonly IntPtr NativeMethodInfoPtr_CheckThemeManager_Private_Void_0;

	// Token: 0x04001158 RID: 4440
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001159 RID: 4441
	private static readonly IntPtr NativeMethodInfoPtr_OnNavPressed_Public_Void_0;

	// Token: 0x0400115A RID: 4442
	private static readonly IntPtr NativeMethodInfoPtr_OnExitButtonPress_Public_Void_0;

	// Token: 0x0400115B RID: 4443
	private static readonly IntPtr NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0;

	// Token: 0x0400115C RID: 4444
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F5 RID: 501
	[ObfuscatedName("UI_MainMenu+<HandleSoakTest>d__7")]
	public sealed class _HandleSoakTest_d__7 : global::Il2CppSystem.Object
	{
		// Token: 0x06002816 RID: 10262 RVA: 0x000916B0 File Offset: 0x0008F8B0
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleSoakTest_d__7()
		{
			Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_MainMenu>.NativeClassPtr, "<HandleSoakTest>d__7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr);
			UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, "<>1__state");
			UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, "<>2__current");
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666450);
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666451);
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666452);
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666453);
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666454);
			UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr, 100666455);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0009177C File Offset: 0x0008F97C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleSoakTest_d__7(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_MainMenu._HandleSoakTest_d__7>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000917C4 File Offset: 0x0008F9C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000917F8 File Offset: 0x0008F9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250401, XrefRangeEnd = 250408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x00091834 File Offset: 0x0008FA34
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00091874 File Offset: 0x0008FA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250408, XrefRangeEnd = 250413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x000918A8 File Offset: 0x0008FAA8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_MainMenu._HandleSoakTest_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00018BF3 File Offset: 0x00016DF3
		public _HandleSoakTest_d__7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x000918E8 File Offset: 0x0008FAE8
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x00018BFC File Offset: 0x00016DFC
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x00091910 File Offset: 0x0008FB10
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x00018C17 File Offset: 0x00016E17
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_MainMenu._HandleSoakTest_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

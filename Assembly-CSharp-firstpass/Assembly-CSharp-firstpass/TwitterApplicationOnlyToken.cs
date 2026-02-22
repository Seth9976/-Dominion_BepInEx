using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class TwitterApplicationOnlyToken : Singleton<TwitterApplicationOnlyToken>
{
	// Token: 0x06000BCE RID: 3022 RVA: 0x00040778 File Offset: 0x0003E978
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterApplicationOnlyToken()
	{
		Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterApplicationOnlyToken");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr);
		TwitterApplicationOnlyToken.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "ActionComplete");
		TwitterApplicationOnlyToken.NativeFieldInfoPtr__currentToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "_currentToken");
		TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "TWITTER_CONSUMER_KEY");
		TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "TWITTER_CONSUMER_SECRET");
		TwitterApplicationOnlyToken.NativeFieldInfoPtr_BEARER_TOKEN_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "BEARER_TOKEN_KEY");
		TwitterApplicationOnlyToken.NativeFieldInfoPtr_Headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "Headers");
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664729);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664730);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664731);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_RetrieveToken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664732);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_get_currentToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664733);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr_Load_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664734);
		TwitterApplicationOnlyToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, 100664735);
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x000408AC File Offset: 0x0003EAAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175023, RefRangeEnd = 175024, XrefRangeStart = 175019, XrefRangeEnd = 175023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x000408F0 File Offset: 0x0003EAF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175028, RefRangeEnd = 175029, XrefRangeStart = 175024, XrefRangeEnd = 175028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00040934 File Offset: 0x0003EB34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175029, XrefRangeEnd = 175034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00040968 File Offset: 0x0003EB68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175039, RefRangeEnd = 175040, XrefRangeStart = 175034, XrefRangeEnd = 175039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_RetrieveToken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0004099C File Offset: 0x0003EB9C
	public unsafe string currentToken
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175045, RefRangeEnd = 175047, XrefRangeStart = 175040, XrefRangeEnd = 175045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_get_currentToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x000409D4 File Offset: 0x0003EBD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175047, XrefRangeEnd = 175051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr_Load_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00040A14 File Offset: 0x0003EC14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175051, XrefRangeEnd = 175077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterApplicationOnlyToken()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00006B44 File Offset: 0x00004D44
	public TwitterApplicationOnlyToken(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00040A50 File Offset: 0x0003EC50
	// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00006B4D File Offset: 0x00004D4D
	public unsafe Action ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x00040A80 File Offset: 0x0003EC80
	// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00006B6C File Offset: 0x00004D6C
	public unsafe string _currentToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr__currentToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr__currentToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00040AA8 File Offset: 0x0003ECA8
	// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00006B8B File Offset: 0x00004D8B
	public unsafe static string TWITTER_CONSUMER_KEY
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00040AC8 File Offset: 0x0003ECC8
	// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00006B9D File Offset: 0x00004D9D
	public unsafe static string TWITTER_CONSUMER_SECRET
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00040AE8 File Offset: 0x0003ECE8
	// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00006BAF File Offset: 0x00004DAF
	public unsafe static string BEARER_TOKEN_KEY
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_BEARER_TOKEN_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterApplicationOnlyToken.NativeFieldInfoPtr_BEARER_TOKEN_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003C5 RID: 965
	// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00040B08 File Offset: 0x0003ED08
	// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00006BC1 File Offset: 0x00004DC1
	public unsafe Dictionary<string, string> Headers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr_Headers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken.NativeFieldInfoPtr_Headers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000955 RID: 2389
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x04000956 RID: 2390
	private static readonly IntPtr NativeFieldInfoPtr__currentToken;

	// Token: 0x04000957 RID: 2391
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_CONSUMER_KEY;

	// Token: 0x04000958 RID: 2392
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET;

	// Token: 0x04000959 RID: 2393
	private static readonly IntPtr NativeFieldInfoPtr_BEARER_TOKEN_KEY;

	// Token: 0x0400095A RID: 2394
	private static readonly IntPtr NativeFieldInfoPtr_Headers;

	// Token: 0x0400095B RID: 2395
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_0;

	// Token: 0x0400095C RID: 2396
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_0;

	// Token: 0x0400095D RID: 2397
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400095E RID: 2398
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveToken_Public_Void_0;

	// Token: 0x0400095F RID: 2399
	private static readonly IntPtr NativeMethodInfoPtr_get_currentToken_Public_get_String_0;

	// Token: 0x04000960 RID: 2400
	private static readonly IntPtr NativeMethodInfoPtr_Load_Private_IEnumerator_0;

	// Token: 0x04000961 RID: 2401
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000383 RID: 899
	[ObfuscatedName("TwitterApplicationOnlyToken+<Load>d__12")]
	public sealed class _Load_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x060035A1 RID: 13729 RVA: 0x000DCFC4 File Offset: 0x000DB1C4
		// Note: this type is marked as 'beforefieldinit'.
		static _Load_d__12()
		{
			Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "<Load>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr);
			TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, "<>1__state");
			TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, "<>2__current");
			TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, "<>4__this");
			TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, "<www>5__2");
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670139);
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670140);
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670141);
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670142);
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670143);
			TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr, 100670144);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x000DD0B8 File Offset: 0x000DB2B8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Load_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApplicationOnlyToken._Load_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x000DD100 File Offset: 0x000DB300
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000DD134 File Offset: 0x000DB334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174950, XrefRangeEnd = 175014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x000DD170 File Offset: 0x000DB370
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000DD1B0 File Offset: 0x000DB3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175014, XrefRangeEnd = 175019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x000DD1E4 File Offset: 0x000DB3E4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken._Load_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x00014C52 File Offset: 0x00012E52
		public _Load_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x000DD224 File Offset: 0x000DB424
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x00014C5B File Offset: 0x00012E5B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x000DD24C File Offset: 0x000DB44C
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x00014C76 File Offset: 0x00012E76
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x000DD27C File Offset: 0x000DB47C
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x00014C95 File Offset: 0x00012E95
		public unsafe TwitterApplicationOnlyToken __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterApplicationOnlyToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x000DD2AC File Offset: 0x000DB4AC
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x00014CB4 File Offset: 0x00012EB4
		public unsafe WWW _www_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr__www_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApplicationOnlyToken._Load_d__12.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000384 RID: 900
	[ObfuscatedName("TwitterApplicationOnlyToken+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060035B1 RID: 13745 RVA: 0x000DD2DC File Offset: 0x000DB4DC
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterApplicationOnlyToken>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr);
			TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr, "<>9");
			TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr, "<>9__13_0");
			TwitterApplicationOnlyToken.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr, 100670146);
			TwitterApplicationOnlyToken.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr, 100670147);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x000DD358 File Offset: 0x000DB558
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApplicationOnlyToken.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x000DD394 File Offset: 0x000DB594
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApplicationOnlyToken.__c.NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00014CD3 File Offset: 0x00012ED3
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x000DD3C8 File Offset: 0x000DB5C8
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x00014CDC File Offset: 0x00012EDC
		public unsafe static TwitterApplicationOnlyToken.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterApplicationOnlyToken.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x000DD3F0 File Offset: 0x000DB5F0
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x00014CEE File Offset: 0x00012EEE
		public unsafe static Action __9__13_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterApplicationOnlyToken.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_0_Internal_Void_0;
	}
}

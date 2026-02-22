using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000046 RID: 70
public class AscensionDebug : Object
{
	// Token: 0x06000BB1 RID: 2993 RVA: 0x0003C360 File Offset: 0x0003A560
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionDebug()
	{
		Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionDebug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr);
		AscensionDebug.NativeFieldInfoPtr_DLL_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, "DLL_NAME");
		AscensionDebug.NativeMethodInfoPtr_SetDebugFunction_Public_Static_Void_DebugDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, 100664105);
		AscensionDebug.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, 100664106);
		AscensionDebug.NativeMethodInfoPtr_DebugCallBackFunction_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, 100664107);
		AscensionDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, 100664108);
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x0003C3F4 File Offset: 0x0003A5F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237591, XrefRangeEnd = 237593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDebugFunction(AscensionDebug.DebugDelegate pDebugDelegate)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pDebugDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.NativeMethodInfoPtr_SetDebugFunction_Public_Static_Void_DebugDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0003C42C File Offset: 0x0003A62C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237593, XrefRangeEnd = 237601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0003C454 File Offset: 0x0003A654
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DebugCallBackFunction(string str)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.NativeMethodInfoPtr_DebugCallBackFunction_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x0003C48C File Offset: 0x0003A68C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionDebug()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x000091EF File Offset: 0x000073EF
	public AscensionDebug(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
	// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000091F8 File Offset: 0x000073F8
	public unsafe static string DLL_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AscensionDebug.NativeFieldInfoPtr_DLL_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionDebug.NativeFieldInfoPtr_DLL_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000747 RID: 1863
	private static readonly IntPtr NativeFieldInfoPtr_DLL_NAME;

	// Token: 0x04000748 RID: 1864
	private static readonly IntPtr NativeMethodInfoPtr_SetDebugFunction_Public_Static_Void_DebugDelegate_0;

	// Token: 0x04000749 RID: 1865
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	// Token: 0x0400074A RID: 1866
	private static readonly IntPtr NativeMethodInfoPtr_DebugCallBackFunction_Private_Static_Void_String_0;

	// Token: 0x0400074B RID: 1867
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000181 RID: 385
	public sealed class DebugDelegate : MulticastDelegate
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x00085E10 File Offset: 0x00084010
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDelegate()
		{
			Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionDebug>.NativeClassPtr, "DebugDelegate");
			AscensionDebug.DebugDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr, 100666144);
			AscensionDebug.DebugDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr, 100666145);
			AscensionDebug.DebugDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr, 100666146);
			AscensionDebug.DebugDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr, 100666147);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00085E84 File Offset: 0x00084084
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDebug.DebugDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.DebugDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00085EE0 File Offset: 0x000840E0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.DebugDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00085F24 File Offset: 0x00084124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(string str, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.DebugDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00085F98 File Offset: 0x00084198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDebug.DebugDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0001667C File Offset: 0x0001487C
		public DebugDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00016685 File Offset: 0x00014885
		public static implicit operator AscensionDebug.DebugDelegate(Action<string> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionDebug.DebugDelegate>(A_0);
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0001668D File Offset: 0x0001488D
		public static AscensionDebug.DebugDelegate operator +(AscensionDebug.DebugDelegate A_0, AscensionDebug.DebugDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionDebug.DebugDelegate>();
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0001669B File Offset: 0x0001489B
		public static AscensionDebug.DebugDelegate operator -(AscensionDebug.DebugDelegate A_0, AscensionDebug.DebugDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionDebug.DebugDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

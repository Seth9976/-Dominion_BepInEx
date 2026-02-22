using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Models;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class AN_PlusShareListener : MonoBehaviour
{
	// Token: 0x06000450 RID: 1104 RVA: 0x00025248 File Offset: 0x00023448
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PlusShareListener()
	{
		Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PlusShareListener");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr);
		AN_PlusShareListener.NativeFieldInfoPtr_builderCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, "builderCallback");
		AN_PlusShareListener.NativeMethodInfoPtr_AttachBuilderCallback_Public_Void_PlusShareCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, 100663784);
		AN_PlusShareListener.NativeMethodInfoPtr_OnPlusShareCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, 100663785);
		AN_PlusShareListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, 100663786);
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x000252C8 File Offset: 0x000234C8
	[CallerCount(0)]
	public unsafe void AttachBuilderCallback(AN_PlusShareListener.PlusShareCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.NativeMethodInfoPtr_AttachBuilderCallback_Public_Void_PlusShareCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0002530C File Offset: 0x0002350C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163503, XrefRangeEnd = 163521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlusShareCallback(string res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.NativeMethodInfoPtr_OnPlusShareCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00025350 File Offset: 0x00023550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163521, XrefRangeEnd = 163536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PlusShareListener()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00003E1D File Offset: 0x0000201D
	public AN_PlusShareListener(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000455 RID: 1109 RVA: 0x0002538C File Offset: 0x0002358C
	// (set) Token: 0x06000456 RID: 1110 RVA: 0x00003E26 File Offset: 0x00002026
	public unsafe AN_PlusShareListener.PlusShareCallback builderCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareListener.NativeFieldInfoPtr_builderCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusShareListener.PlusShareCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareListener.NativeFieldInfoPtr_builderCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400033B RID: 827
	private static readonly IntPtr NativeFieldInfoPtr_builderCallback;

	// Token: 0x0400033C RID: 828
	private static readonly IntPtr NativeMethodInfoPtr_AttachBuilderCallback_Public_Void_PlusShareCallback_0;

	// Token: 0x0400033D RID: 829
	private static readonly IntPtr NativeMethodInfoPtr_OnPlusShareCallback_Private_Void_String_0;

	// Token: 0x0400033E RID: 830
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200036B RID: 875
	public sealed class PlusShareCallback : MulticastDelegate
	{
		// Token: 0x06003483 RID: 13443 RVA: 0x000D9184 File Offset: 0x000D7384
		// Note: this type is marked as 'beforefieldinit'.
		static PlusShareCallback()
		{
			Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, "PlusShareCallback");
			AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr, 100669975);
			AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr, 100669976);
			AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr, 100669977);
			AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr, 100669978);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000D91F8 File Offset: 0x000D73F8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlusShareCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusShareListener.PlusShareCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x000D9254 File Offset: 0x000D7454
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x000D9298 File Offset: 0x000D7498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163500, XrefRangeEnd = 163501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000D930C File Offset: 0x000D750C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.PlusShareCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00014802 File Offset: 0x00012A02
		public PlusShareCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x0001480B File Offset: 0x00012A0B
		public static implicit operator AN_PlusShareListener.PlusShareCallback(Action<Result> A_0)
		{
			return DelegateSupport.ConvertDelegate<AN_PlusShareListener.PlusShareCallback>(A_0);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00014813 File Offset: 0x00012A13
		public static AN_PlusShareListener.PlusShareCallback operator +(AN_PlusShareListener.PlusShareCallback A_0, AN_PlusShareListener.PlusShareCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AN_PlusShareListener.PlusShareCallback>();
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00014821 File Offset: 0x00012A21
		public static AN_PlusShareListener.PlusShareCallback operator -(AN_PlusShareListener.PlusShareCallback A_0, AN_PlusShareListener.PlusShareCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AN_PlusShareListener.PlusShareCallback>();
			}
			return delegate2;
		}

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x0200036C RID: 876
	[ObfuscatedName("AN_PlusShareListener+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600348C RID: 13452 RVA: 0x000D9350 File Offset: 0x000D7550
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_PlusShareListener>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr);
			AN_PlusShareListener.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr, "<>9");
			AN_PlusShareListener.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr, "<>9__4_0");
			AN_PlusShareListener.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr, 100669980);
			AN_PlusShareListener.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr, 100669981);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000D93CC File Offset: 0x000D75CC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusShareListener.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000D9408 File Offset: 0x000D7608
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__4_0(Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareListener.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00014832 File Offset: 0x00012A32
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x000D944C File Offset: 0x000D764C
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x0001483B File Offset: 0x00012A3B
		public unsafe static AN_PlusShareListener.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_PlusShareListener.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusShareListener.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_PlusShareListener.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x000D9474 File Offset: 0x000D7674
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x0001484D File Offset: 0x00012A4D
		public unsafe static AN_PlusShareListener.PlusShareCallback __9__4_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_PlusShareListener.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusShareListener.PlusShareCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_PlusShareListener.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_Result_0;
	}
}

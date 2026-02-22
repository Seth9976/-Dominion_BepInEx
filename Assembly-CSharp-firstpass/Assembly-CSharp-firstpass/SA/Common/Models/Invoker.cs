using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Common.Models
{
	// Token: 0x02000316 RID: 790
	public class Invoker : MonoBehaviour
	{
		// Token: 0x06002D71 RID: 11633 RVA: 0x000C1C18 File Offset: 0x000BFE18
		// Note: this type is marked as 'beforefieldinit'.
		static Invoker()
		{
			Il2CppClassPointerStore<Invoker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "Invoker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Invoker>.NativeClassPtr);
			Invoker.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Invoker>.NativeClassPtr, "_callback");
			Invoker.NativeMethodInfoPtr_Create_Public_Static_Invoker_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invoker>.NativeClassPtr, 100669230);
			Invoker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invoker>.NativeClassPtr, 100669231);
			Invoker.NativeMethodInfoPtr_StartInvoke_Public_Void_Action_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invoker>.NativeClassPtr, 100669232);
			Invoker.NativeMethodInfoPtr_TimeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invoker>.NativeClassPtr, 100669233);
			Invoker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invoker>.NativeClassPtr, 100669234);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000C1CC0 File Offset: 0x000BFEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212509, RefRangeEnd = 212510, XrefRangeStart = 212498, XrefRangeEnd = 212509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Invoker Create(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invoker.NativeMethodInfoPtr_Create_Public_Static_Invoker_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Invoker>(intPtr3) : null;
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000C1D04 File Offset: 0x000BFF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212510, XrefRangeEnd = 212515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invoker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000C1D38 File Offset: 0x000BFF38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212518, RefRangeEnd = 212519, XrefRangeStart = 212515, XrefRangeEnd = 212518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInvoke(Action callback, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invoker.NativeMethodInfoPtr_StartInvoke_Public_Void_Action_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000C1D88 File Offset: 0x000BFF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212519, XrefRangeEnd = 212525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invoker.NativeMethodInfoPtr_TimeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000C1DBC File Offset: 0x000BFFBC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Invoker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Invoker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invoker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00011A18 File Offset: 0x0000FC18
		public Invoker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000C1DF8 File Offset: 0x000BFFF8
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x00011A21 File Offset: 0x0000FC21
		public unsafe Action _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invoker.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invoker.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Invoker_String_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_StartInvoke_Public_Void_Action_Single_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_TimeOut_Private_Void_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

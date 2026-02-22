using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000094 RID: 148
	public sealed class X509ChainElementEnumerator : Object
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00030F50 File Offset: 0x0002F150
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElementEnumerator()
		{
			Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElementEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr);
			X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, "enumerator");
			X509ChainElementEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100664454);
			X509ChainElementEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100664455);
			X509ChainElementEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100664456);
			X509ChainElementEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100664457);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00030FE4 File Offset: 0x0002F1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42678, XrefRangeEnd = 42682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElementEnumerator(IEnumerable enumerable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00031030 File Offset: 0x0002F230
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42682, XrefRangeEnd = 42686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00031070 File Offset: 0x0002F270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42686, XrefRangeEnd = 42690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000310AC File Offset: 0x0002F2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42690, XrefRangeEnd = 42694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00005872 File Offset: 0x00003A72
		public X509ChainElementEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000310E0 File Offset: 0x0002F2E0
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0000587B File Offset: 0x00003A7B
		public unsafe IEnumerator enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_enumerator;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}

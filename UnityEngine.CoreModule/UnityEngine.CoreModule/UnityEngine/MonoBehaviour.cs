using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x020000B7 RID: 183
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x00044318 File Offset: 0x00042518
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviour()
		{
			Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MonoBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664413);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664414);
			MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664415);
			MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664416);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664417);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664418);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664419);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664420);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664421);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664422);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664423);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664424);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664425);
			MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664426);
			MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664427);
			MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664428);
			MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664429);
			MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664430);
			MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664431);
			MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664432);
			MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664433);
			MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664434);
			MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664435);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664436);
			MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664437);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664438);
			MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664439);
			MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664440);
			MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr, 100664441);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0004458C File Offset: 0x0004278C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72027, XrefRangeEnd = 72029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvoking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000445C8 File Offset: 0x000427C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72029, XrefRangeEnd = 72031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000445FC File Offset: 0x000427FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 72033, RefRangeEnd = 72043, XrefRangeStart = 72031, XrefRangeEnd = 72033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string methodName, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0004464C File Offset: 0x0004284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72043, XrefRangeEnd = 72051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeRepeating(string methodName, float time, float repeatRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000446AC File Offset: 0x000428AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72053, RefRangeEnd = 72055, XrefRangeStart = 72051, XrefRangeEnd = 72053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInvoke(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000446F0 File Offset: 0x000428F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72055, XrefRangeEnd = 72057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInvoking(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00044740 File Offset: 0x00042940
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 72074, RefRangeEnd = 72084, XrefRangeStart = 72057, XrefRangeEnd = 72074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00044790 File Offset: 0x00042990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72084, XrefRangeEnd = 72101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000447F4 File Offset: 0x000429F4
		[CallerCount(107)]
		[CachedScanResults(RefRangeStart = 72117, RefRangeEnd = 72224, XrefRangeStart = 72101, XrefRangeEnd = 72117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00044844 File Offset: 0x00042A44
		[CallerCount(107)]
		[CachedScanResults(RefRangeStart = 72117, RefRangeEnd = 72224, XrefRangeStart = 72117, XrefRangeEnd = 72224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00044894 File Offset: 0x00042A94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72240, RefRangeEnd = 72243, XrefRangeStart = 72224, XrefRangeEnd = 72240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000448D8 File Offset: 0x00042AD8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 72259, RefRangeEnd = 72277, XrefRangeStart = 72243, XrefRangeEnd = 72259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(Coroutine routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0004491C File Offset: 0x00042B1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 72279, RefRangeEnd = 72285, XrefRangeStart = 72277, XrefRangeEnd = 72279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutine(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00044960 File Offset: 0x00042B60
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 72287, RefRangeEnd = 72299, XrefRangeStart = 72285, XrefRangeEnd = 72287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllCoroutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00044994 File Offset: 0x00042B94
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x000449D0 File Offset: 0x00042BD0
		public unsafe bool useGUILayout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72299, XrefRangeEnd = 72301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72301, XrefRangeEnd = 72303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00044A10 File Offset: 0x00042C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72303, XrefRangeEnd = 72318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void print(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_print_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00044A48 File Offset: 0x00042C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CancelInvokeAll(MonoBehaviour self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00044A80 File Offset: 0x00042C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_IsInvokingAll(MonoBehaviour self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00044AC4 File Offset: 0x00042CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72318, XrefRangeEnd = 72320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00044B28 File Offset: 0x00042D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72053, RefRangeEnd = 72055, XrefRangeStart = 72053, XrefRangeEnd = 72055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelInvoke(MonoBehaviour self, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00044B70 File Offset: 0x00042D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInvoking(MonoBehaviour self, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00044BC4 File Offset: 0x00042DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72320, XrefRangeEnd = 72322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsObjectMonoBehaviour(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00044C08 File Offset: 0x00042E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72322, XrefRangeEnd = 72324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutineManaged(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00044C6C File Offset: 0x00042E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72324, XrefRangeEnd = 72326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine StartCoroutineManaged2(IEnumerator enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00044CBC File Offset: 0x00042EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72326, XrefRangeEnd = 72328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutineManaged(Coroutine routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00044D00 File Offset: 0x00042F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72328, XrefRangeEnd = 72330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00044D44 File Offset: 0x00042F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72330, XrefRangeEnd = 72332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetScriptClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr_GetScriptClassName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00044D7C File Offset: 0x00042F7C
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 59667, RefRangeEnd = 59946, XrefRangeStart = 59667, XrefRangeEnd = 59946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000A439 File Offset: 0x00008639
		public MonoBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Public_Void_String_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Public_Boolean_String_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_String_Object_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Public_Coroutine_IEnumerator_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutine_Auto_Public_Coroutine_IEnumerator_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_IEnumerator_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_Coroutine_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutine_Public_Void_String_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_StopAllCoroutines_Public_Void_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_get_useGUILayout_Public_get_Boolean_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_set_useGUILayout_Public_set_Void_Boolean_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_print_Public_Static_Void_Object_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CancelInvokeAll_Private_Static_Void_MonoBehaviour_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_Internal_IsInvokingAll_Private_Static_Boolean_MonoBehaviour_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDelayed_Private_Static_Void_MonoBehaviour_String_Single_Single_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_CancelInvoke_Private_Static_Void_MonoBehaviour_String_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_IsInvoking_Private_Static_Boolean_MonoBehaviour_String_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectMonoBehaviour_Private_Static_Boolean_Object_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutineManaged_Private_Coroutine_String_Object_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_StartCoroutineManaged2_Private_Coroutine_IEnumerator_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutineManaged_Private_Void_Coroutine_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_StopCoroutineFromEnumeratorManaged_Private_Void_IEnumerator_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptClassName_Internal_String_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

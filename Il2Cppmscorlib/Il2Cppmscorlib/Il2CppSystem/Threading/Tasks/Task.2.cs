using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029F RID: 671
	public class Task : Object
	{
		// Token: 0x06002D3E RID: 11582 RVA: 0x000E5B58 File Offset: 0x000E3D58
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_t_currentTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_currentTask");
			Task.NativeFieldInfoPtr_t_stackGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "t_stackGuard");
			Task.NativeFieldInfoPtr_s_taskIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskIdCounter");
			Task.NativeFieldInfoPtr_s_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_factory");
			Task.NativeFieldInfoPtr_m_taskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskId");
			Task.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_action");
			Task.NativeFieldInfoPtr_m_stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateObject");
			Task.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_taskScheduler");
			Task.NativeFieldInfoPtr_m_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_parent");
			Task.NativeFieldInfoPtr_m_stateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_stateFlags");
			Task.NativeFieldInfoPtr_m_continuationObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_continuationObject");
			Task.NativeFieldInfoPtr_s_taskCompletionSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCompletionSentinel");
			Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_asyncDebuggingEnabled");
			Task.NativeFieldInfoPtr_s_currentActiveTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_currentActiveTasks");
			Task.NativeFieldInfoPtr_s_activeTasksLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_activeTasksLock");
			Task.NativeFieldInfoPtr_m_contingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "m_contingentProperties");
			Task.NativeFieldInfoPtr_s_taskCancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_taskCancelCallback");
			Task.NativeFieldInfoPtr_s_createContingentProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_createContingentProperties");
			Task.NativeFieldInfoPtr_s_completedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_completedTask");
			Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsExceptionObservedByParentPredicate");
			Task.NativeFieldInfoPtr_s_ecCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_ecCallback");
			Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "s_IsTaskContinuationNullPredicate");
			Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670446);
			Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670447);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670448);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670449);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670450);
			Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670451);
			Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670452);
			Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670453);
			Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670454);
			Task.NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670455);
			Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670456);
			Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670457);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670458);
			Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670459);
			Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670460);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670461);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670462);
			Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670463);
			Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670464);
			Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670465);
			Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670466);
			Task.NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670467);
			Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670468);
			Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670469);
			Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670470);
			Task.NativeMethodInfoPtr_NewId_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670471);
			Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670472);
			Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670473);
			Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670474);
			Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670475);
			Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670476);
			Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670477);
			Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670478);
			Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670479);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670480);
			Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670481);
			Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670482);
			Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670483);
			Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670484);
			Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670485);
			Task.NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670486);
			Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670487);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670488);
			Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670489);
			Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670490);
			Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670491);
			Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670492);
			Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670493);
			Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670494);
			Task.NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670495);
			Task.NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670496);
			Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670497);
			Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670498);
			Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670499);
			Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670500);
			Task.NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670501);
			Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670502);
			Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670503);
			Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670504);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670505);
			Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670506);
			Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670507);
			Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670508);
			Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670509);
			Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670510);
			Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670511);
			Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670512);
			Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670513);
			Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670514);
			Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670515);
			Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670516);
			Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670517);
			Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670518);
			Task.NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670519);
			Task.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670520);
			Task.NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670521);
			Task.NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670522);
			Task.NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670523);
			Task.NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670524);
			Task.NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670525);
			Task.NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670526);
			Task.NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670527);
			Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670528);
			Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670529);
			Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670530);
			Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670531);
			Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670532);
			Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670533);
			Task.NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670534);
			Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670535);
			Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670536);
			Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670537);
			Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670538);
			Task.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670539);
			Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670540);
			Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670541);
			Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670542);
			Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670543);
			Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670544);
			Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670545);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670546);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670547);
			Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670548);
			Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670549);
			Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670550);
			Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670551);
			Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670552);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670553);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670554);
			Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670555);
			Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670556);
			Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670557);
			Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670558);
			Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670559);
			Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670560);
			Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670561);
			Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670562);
			Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670563);
			Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670564);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670565);
			Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670566);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670567);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670568);
			Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670569);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670570);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670571);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670572);
			Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670573);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670574);
			Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670575);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670576);
			Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100670577);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000E6790 File Offset: 0x000E4990
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 334524, RefRangeEnd = 334532, XrefRangeStart = 334510, XrefRangeEnd = 334524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddToActiveTasks(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000E67D4 File Offset: 0x000E49D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334545, RefRangeEnd = 334552, XrefRangeStart = 334532, XrefRangeEnd = 334545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromActiveTasks(int taskId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref taskId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x000E6808 File Offset: 0x000E4A08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334555, RefRangeEnd = 334558, XrefRangeStart = 334552, XrefRangeEnd = 334555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x000E6874 File Offset: 0x000E4A74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334560, RefRangeEnd = 334563, XrefRangeStart = 334558, XrefRangeEnd = 334560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000E68B0 File Offset: 0x000E4AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334574, RefRangeEnd = 334575, XrefRangeStart = 334563, XrefRangeEnd = 334574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions creationOptions, bool promiseStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promiseStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x000E6918 File Offset: 0x000E4B18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334583, RefRangeEnd = 334587, XrefRangeStart = 334575, XrefRangeEnd = 334583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate action, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000E69D0 File Offset: 0x000E4BD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334599, RefRangeEnd = 334604, XrefRangeStart = 334587, XrefRangeEnd = 334599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskConstructorCore(Object action, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x000E6A6C File Offset: 0x000E4C6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334643, RefRangeEnd = 334646, XrefRangeStart = 334604, XrefRangeEnd = 334643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000E6AD8 File Offset: 0x000E4CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334646, XrefRangeEnd = 334656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TaskCancelCallback(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000E6B10 File Offset: 0x000E4D10
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 334661, RefRangeEnd = 334669, XrefRangeStart = 334656, XrefRangeEnd = 334661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PossiblyCaptureContext(ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stackMark;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000E6B50 File Offset: 0x000E4D50
		public unsafe TaskCreationOptions Options
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334673, RefRangeEnd = 334675, XrefRangeStart = 334669, XrefRangeEnd = 334673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000E6B8C File Offset: 0x000E4D8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TaskCreationOptions OptionsMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000E6BCC File Offset: 0x000E4DCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334680, RefRangeEnd = 334686, XrefRangeStart = 334675, XrefRangeEnd = 334680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000E6C24 File Offset: 0x000E4E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334686, XrefRangeEnd = 334691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newBits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref illegalBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &oldFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000E6C8C File Offset: 0x000E4E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334698, RefRangeEnd = 334699, XrefRangeStart = 334691, XrefRangeEnd = 334698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationForWaitCompletion(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000E6CCC File Offset: 0x000E4ECC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334701, RefRangeEnd = 334706, XrefRangeStart = 334699, XrefRangeEnd = 334701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000E6D08 File Offset: 0x000E4F08
		public unsafe bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334706, XrefRangeEnd = 334707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000E6D44 File Offset: 0x000E4F44
		public unsafe virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334707, XrefRangeEnd = 334708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000E6D8C File Offset: 0x000E4F8C
		public unsafe bool IsWaitNotificationEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000E6DC8 File Offset: 0x000E4FC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334709, RefRangeEnd = 334713, XrefRangeStart = 334708, XrefRangeEnd = 334709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDebuggerOfWaitCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x000E6DFC File Offset: 0x000E4FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334718, RefRangeEnd = 334720, XrefRangeStart = 334713, XrefRangeEnd = 334718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MarkStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000E6E38 File Offset: 0x000E5038
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FireTaskScheduledIfNeeded(TaskScheduler ts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000E6E88 File Offset: 0x000E5088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334720, XrefRangeEnd = 334728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNewChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddNewChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x000E6EBC File Offset: 0x000E50BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334728, XrefRangeEnd = 334732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisregardChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_DisregardChild_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000E6EF0 File Offset: 0x000E50F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334732, XrefRangeEnd = 334743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalStartNew(Task creatingTask, Delegate action, Object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creatingTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000E6FB0 File Offset: 0x000E51B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334743, XrefRangeEnd = 334748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NewId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_NewId_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000E6FE0 File Offset: 0x000E51E0
		public unsafe int Id
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 334761, RefRangeEnd = 334792, XrefRangeStart = 334748, XrefRangeEnd = 334761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000E701C File Offset: 0x000E521C
		public unsafe static Task InternalCurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334792, XrefRangeEnd = 334797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000E7050 File Offset: 0x000E5250
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 334806, RefRangeEnd = 334814, XrefRangeStart = 334797, XrefRangeEnd = 334806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000E7090 File Offset: 0x000E5290
		public unsafe static StackGuard CurrentStackGuard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334827, RefRangeEnd = 334828, XrefRangeStart = 334814, XrefRangeEnd = 334827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr3) : null;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000E70C4 File Offset: 0x000E52C4
		public unsafe AggregateException Exception
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334830, RefRangeEnd = 334831, XrefRangeStart = 334828, XrefRangeEnd = 334830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000E7104 File Offset: 0x000E5304
		public unsafe TaskStatus Status
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 334832, RefRangeEnd = 334835, XrefRangeStart = 334831, XrefRangeEnd = 334832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000E7140 File Offset: 0x000E5340
		public unsafe bool IsCanceled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334836, RefRangeEnd = 334837, XrefRangeStart = 334835, XrefRangeEnd = 334836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000E717C File Offset: 0x000E537C
		public unsafe bool IsCancellationRequested
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334837, XrefRangeEnd = 334838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000E71B8 File Offset: 0x000E53B8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 334846, RefRangeEnd = 334857, XrefRangeStart = 334838, XrefRangeEnd = 334846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000E7204 File Offset: 0x000E5404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334857, XrefRangeEnd = 334864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x000E7250 File Offset: 0x000E5450
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334865, RefRangeEnd = 334866, XrefRangeStart = 334864, XrefRangeEnd = 334865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000E7288 File Offset: 0x000E5488
		public unsafe bool IsCancellationAcknowledged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334866, XrefRangeEnd = 334867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000E72C4 File Offset: 0x000E54C4
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 334871, RefRangeEnd = 334907, XrefRangeStart = 334867, XrefRangeEnd = 334871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000E7300 File Offset: 0x000E5500
		[CallerCount(0)]
		public unsafe static bool IsCompletedMethod(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000E7340 File Offset: 0x000E5540
		public unsafe bool IsRanToCompletion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334908, RefRangeEnd = 334910, XrefRangeStart = 334907, XrefRangeEnd = 334908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000E737C File Offset: 0x000E557C
		public unsafe TaskCreationOptions CreationOptions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334914, RefRangeEnd = 334916, XrefRangeStart = 334910, XrefRangeEnd = 334914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000E73B8 File Offset: 0x000E55B8
		public unsafe virtual WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334916, XrefRangeEnd = 334943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000E73F8 File Offset: 0x000E55F8
		public unsafe virtual Object AsyncState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x000E7438 File Offset: 0x000E5638
		public unsafe virtual bool System.IAsyncResult.CompletedSynchronously
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000E7474 File Offset: 0x000E5674
		public unsafe TaskScheduler ExecutingTaskScheduler
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x000E74B4 File Offset: 0x000E56B4
		public unsafe static TaskFactory Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334943, XrefRangeEnd = 334947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000E74E8 File Offset: 0x000E56E8
		public unsafe static Task CompletedTask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334958, RefRangeEnd = 334960, XrefRangeStart = 334947, XrefRangeEnd = 334958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000E751C File Offset: 0x000E571C
		public unsafe ManualResetEventSlim CompletedEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334960, XrefRangeEnd = 334977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000E755C File Offset: 0x000E575C
		public unsafe bool IsSelfReplicatingRoot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334981, RefRangeEnd = 334982, XrefRangeStart = 334977, XrefRangeEnd = 334981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000E7598 File Offset: 0x000E5798
		public unsafe bool IsChildReplica
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334986, RefRangeEnd = 334987, XrefRangeStart = 334982, XrefRangeEnd = 334986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000E75D4 File Offset: 0x000E57D4
		public unsafe bool ExceptionRecorded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334987, XrefRangeEnd = 334991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x000E7610 File Offset: 0x000E5810
		public unsafe bool IsFaulted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334991, XrefRangeEnd = 334992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000E764C File Offset: 0x000E584C
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x000E768C File Offset: 0x000E588C
		public unsafe ExecutionContext CapturedContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335002, RefRangeEnd = 335003, XrefRangeStart = 334992, XrefRangeEnd = 335002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 335012, RefRangeEnd = 335018, XrefRangeStart = 335003, XrefRangeEnd = 335012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000E76D0 File Offset: 0x000E58D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335024, RefRangeEnd = 335025, XrefRangeStart = 335018, XrefRangeEnd = 335024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capturedContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000E7714 File Offset: 0x000E5914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335025, XrefRangeEnd = 335029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000E7748 File Offset: 0x000E5948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335029, XrefRangeEnd = 335045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000E7794 File Offset: 0x000E5994
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 335071, RefRangeEnd = 335078, XrefRangeStart = 335045, XrefRangeEnd = 335071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleAndStart(bool needsProtection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsProtection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000E77D4 File Offset: 0x000E59D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335079, RefRangeEnd = 335080, XrefRangeStart = 335078, XrefRangeEnd = 335079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000E7818 File Offset: 0x000E5A18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 335137, RefRangeEnd = 335142, XrefRangeStart = 335080, XrefRangeEnd = 335137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddException(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000E7868 File Offset: 0x000E5A68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335160, RefRangeEnd = 335164, XrefRangeStart = 335142, XrefRangeEnd = 335160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000E78B4 File Offset: 0x000E5AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335187, RefRangeEnd = 335188, XrefRangeStart = 335164, XrefRangeEnd = 335187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000E78F4 File Offset: 0x000E5AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335190, RefRangeEnd = 335191, XrefRangeStart = 335188, XrefRangeEnd = 335190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000E7934 File Offset: 0x000E5B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335192, RefRangeEnd = 335193, XrefRangeStart = 335191, XrefRangeEnd = 335192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeTaskCanceledExceptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000E7974 File Offset: 0x000E5B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335193, XrefRangeEnd = 335207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExceptionObservedStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000E79A8 File Offset: 0x000E5BA8
		public unsafe bool IsExceptionObservedByParent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 335208, RefRangeEnd = 335209, XrefRangeStart = 335207, XrefRangeEnd = 335208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000E79E4 File Offset: 0x000E5BE4
		public unsafe bool IsDelegateInvoked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335209, XrefRangeEnd = 335210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000E7A20 File Offset: 0x000E5C20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335231, RefRangeEnd = 335234, XrefRangeStart = 335210, XrefRangeEnd = 335231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish(bool bUserDelegateExecuted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bUserDelegateExecuted;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000E7A60 File Offset: 0x000E5C60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335268, RefRangeEnd = 335271, XrefRangeStart = 335234, XrefRangeEnd = 335268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageTwo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x000E7A94 File Offset: 0x000E5C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335279, RefRangeEnd = 335282, XrefRangeStart = 335271, XrefRangeEnd = 335279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishStageThree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishStageThree_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000E7AC8 File Offset: 0x000E5CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335305, RefRangeEnd = 335306, XrefRangeStart = 335282, XrefRangeEnd = 335305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessChildCompletion(Task childTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000E7B0C File Offset: 0x000E5D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335344, RefRangeEnd = 335345, XrefRangeStart = 335306, XrefRangeEnd = 335344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExceptionsFromChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000E7B40 File Offset: 0x000E5D40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335360, RefRangeEnd = 335364, XrefRangeStart = 335345, XrefRangeEnd = 335360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bTAEAddedToExceptionHolder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateRan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000E7B8C File Offset: 0x000E5D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335374, RefRangeEnd = 335376, XrefRangeStart = 335364, XrefRangeEnd = 335374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000E7BC0 File Offset: 0x000E5DC0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldReplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000E7C08 File Offset: 0x000E5E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335376, XrefRangeEnd = 335381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task CreateReplicaTask(Action<Object> taskReplicaDelegate, Object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskReplicaDelegate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTask);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(taskScheduler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptionsForReplica;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptionsForReplica;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000E7CB8 File Offset: 0x000E5EB8
		public unsafe virtual Object SavedStateForNextReplica
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x000E7D04 File Offset: 0x000E5F04
		public unsafe virtual Object SavedStateFromPreviousReplica
		{
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000E7D54 File Offset: 0x000E5F54
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x000E7DA0 File Offset: 0x000E5FA0
		public unsafe virtual Task HandedOverChildReplica
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000E7DF0 File Offset: 0x000E5FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335381, XrefRangeEnd = 335401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteSelfReplicating(Task root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000E7E28 File Offset: 0x000E6028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335401, XrefRangeEnd = 335402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000E7E5C File Offset: 0x000E605C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335402, XrefRangeEnd = 335408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000E7EA0 File Offset: 0x000E60A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335430, RefRangeEnd = 335432, XrefRangeStart = 335408, XrefRangeEnd = 335430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPreventDoubleExecution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000E7EEC File Offset: 0x000E60EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335484, RefRangeEnd = 335485, XrefRangeStart = 335432, XrefRangeEnd = 335484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTaskSlot);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				currentTaskSlot = ((intPtr4 == 0) ? null : new Task(intPtr4));
			}
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000E7F44 File Offset: 0x000E6144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335485, XrefRangeEnd = 335489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutionContextCallback(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000E7F7C File Offset: 0x000E617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335489, XrefRangeEnd = 335497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x000E7FB8 File Offset: 0x000E61B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335498, RefRangeEnd = 335499, XrefRangeStart = 335497, XrefRangeEnd = 335498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InnerInvokeWithArg(Task childTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x000E7FFC File Offset: 0x000E61FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335514, RefRangeEnd = 335518, XrefRangeStart = 335499, XrefRangeEnd = 335514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleException(Exception unhandledException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unhandledException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_HandleException_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x000E8040 File Offset: 0x000E6240
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter(intPtr);
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x000E8078 File Offset: 0x000E6278
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 335519, RefRangeEnd = 335546, XrefRangeStart = 335518, XrefRangeEnd = 335519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable(intPtr);
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000E80BC File Offset: 0x000E62BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335578, RefRangeEnd = 335579, XrefRangeStart = 335546, XrefRangeEnd = 335578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x000E812C File Offset: 0x000E632C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 335586, RefRangeEnd = 335591, XrefRangeStart = 335579, XrefRangeEnd = 335586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x000E8160 File Offset: 0x000E6360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335591, XrefRangeEnd = 335599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x000E81C0 File Offset: 0x000E63C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335600, RefRangeEnd = 335601, XrefRangeStart = 335599, XrefRangeEnd = 335600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WrappedTryRunInline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000E81FC File Offset: 0x000E63FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335624, RefRangeEnd = 335630, XrefRangeStart = 335601, XrefRangeEnd = 335624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000E825C File Offset: 0x000E645C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335667, RefRangeEnd = 335668, XrefRangeStart = 335630, XrefRangeEnd = 335667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000E82BC File Offset: 0x000E64BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335668, XrefRangeEnd = 335685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SpinWait(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000E8308 File Offset: 0x000E6508
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335711, RefRangeEnd = 335715, XrefRangeStart = 335685, XrefRangeEnd = 335711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bCancelNonExecutingOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000E8354 File Offset: 0x000E6554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335715, XrefRangeEnd = 335717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000E8388 File Offset: 0x000E6588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335717, XrefRangeEnd = 335724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000E83D0 File Offset: 0x000E65D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335732, RefRangeEnd = 335733, XrefRangeStart = 335724, XrefRangeEnd = 335732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordInternalCancellationRequest(CancellationToken tokenToRecord, Object cancellationException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000E842C File Offset: 0x000E662C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335751, RefRangeEnd = 335753, XrefRangeStart = 335733, XrefRangeEnd = 335751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancellationCleanupLogic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000E8460 File Offset: 0x000E6660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335753, XrefRangeEnd = 335755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCancellationAcknowledged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000E8494 File Offset: 0x000E6694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335827, RefRangeEnd = 335828, XrefRangeStart = 335755, XrefRangeEnd = 335827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishContinuations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FinishContinuations_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000E84C8 File Offset: 0x000E66C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335828, XrefRangeEnd = 335830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFinishCompletionNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000E84FC File Offset: 0x000E66FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335853, RefRangeEnd = 335854, XrefRangeStart = 335830, XrefRangeEnd = 335853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000E854C File Offset: 0x000E674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335854, XrefRangeEnd = 335863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000E85E4 File Offset: 0x000E67E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335872, RefRangeEnd = 335873, XrefRangeStart = 335863, XrefRangeEnd = 335872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000E8680 File Offset: 0x000E6880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335873, XrefRangeEnd = 335882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ContinueWith(Action<Task, Object> continuationAction, Object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000E872C File Offset: 0x000E692C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 335882, RefRangeEnd = 335886, XrefRangeStart = 335882, XrefRangeEnd = 335882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &internalOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000E877C File Offset: 0x000E697C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 335905, RefRangeEnd = 335910, XrefRangeStart = 335886, XrefRangeEnd = 335905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000E87F8 File Offset: 0x000E69F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335914, RefRangeEnd = 335917, XrefRangeStart = 335910, XrefRangeEnd = 335914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000E883C File Offset: 0x000E6A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335917, XrefRangeEnd = 335921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000E888C File Offset: 0x000E6A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335921, XrefRangeEnd = 335964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuationComplex(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000E88E8 File Offset: 0x000E6AE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 335971, RefRangeEnd = 335978, XrefRangeStart = 335964, XrefRangeEnd = 335971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddTaskContinuation(Object tc, bool addBeforeOthers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addBeforeOthers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000E8944 File Offset: 0x000E6B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336008, RefRangeEnd = 336012, XrefRangeStart = 335978, XrefRangeEnd = 336008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContinuation(Object continuationObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000E8988 File Offset: 0x000E6B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336014, RefRangeEnd = 336015, XrefRangeStart = 336012, XrefRangeEnd = 336014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromResult<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000E8A04 File Offset: 0x000E6C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336021, RefRangeEnd = 336023, XrefRangeStart = 336015, XrefRangeEnd = 336021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000E8A48 File Offset: 0x000E6C48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336025, RefRangeEnd = 336029, XrefRangeStart = 336023, XrefRangeEnd = 336025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromException<TResult>(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000E8A8C File Offset: 0x000E6C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336041, RefRangeEnd = 336043, XrefRangeStart = 336029, XrefRangeEnd = 336041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task FromCancellation(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000E8AD8 File Offset: 0x000E6CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336043, XrefRangeEnd = 336046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000E8B24 File Offset: 0x000E6D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336048, RefRangeEnd = 336049, XrefRangeStart = 336046, XrefRangeEnd = 336048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000E8B68 File Offset: 0x000E6D68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336072, RefRangeEnd = 336074, XrefRangeStart = 336049, XrefRangeEnd = 336072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Run(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Run_Public_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000E8BAC File Offset: 0x000E6DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336086, RefRangeEnd = 336087, XrefRangeStart = 336074, XrefRangeEnd = 336086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000E8BF0 File Offset: 0x000E6DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336090, RefRangeEnd = 336092, XrefRangeStart = 336087, XrefRangeEnd = 336090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000E8C34 File Offset: 0x000E6E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336092, XrefRangeEnd = 336107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000E8C90 File Offset: 0x000E6E90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336111, RefRangeEnd = 336115, XrefRangeStart = 336107, XrefRangeEnd = 336111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000E8CD0 File Offset: 0x000E6ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336155, RefRangeEnd = 336157, XrefRangeStart = 336115, XrefRangeEnd = 336155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsDelay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000E8D28 File Offset: 0x000E6F28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 336191, RefRangeEnd = 336196, XrefRangeStart = 336157, XrefRangeEnd = 336191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny([Optional] Il2CppReferenceArray<Task> tasks)
		{
			if (tasks == null)
			{
				tasks = new Il2CppReferenceArray<Task>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000E8D7C File Offset: 0x000E6F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336196, XrefRangeEnd = 336248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x0000FE28 File Offset: 0x0000E028
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return Task.WhenAny(new Il2CppReferenceArray<Task>(tasks));
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x0000FE35 File Offset: 0x0000E035
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000E8DC0 File Offset: 0x000E6FC0
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x0000FE3E File Offset: 0x0000E03E
		public unsafe static Task t_currentTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_currentTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_currentTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000E8DE8 File Offset: 0x000E6FE8
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x0000FE50 File Offset: 0x0000E050
		public unsafe static StackGuard t_stackGuard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_t_stackGuard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_t_stackGuard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000E8E10 File Offset: 0x000E7010
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x0000FE62 File Offset: 0x0000E062
		public unsafe static int s_taskIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000E8E2C File Offset: 0x000E702C
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x0000FE70 File Offset: 0x0000E070
		public unsafe static TaskFactory s_factory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_factory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_factory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000E8E54 File Offset: 0x000E7054
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x0000FE82 File Offset: 0x0000E082
		public unsafe int m_taskId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskId)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000E8E7C File Offset: 0x000E707C
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x0000FE9D File Offset: 0x0000E09D
		public unsafe Object m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000E8EAC File Offset: 0x000E70AC
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		public unsafe Object m_stateObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000E8EDC File Offset: 0x000E70DC
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x0000FEDB File Offset: 0x0000E0DB
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x000E8F0C File Offset: 0x000E710C
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x0000FEFA File Offset: 0x0000E0FA
		public unsafe Task m_parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000E8F3C File Offset: 0x000E713C
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x0000FF19 File Offset: 0x0000E119
		public unsafe int m_stateFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_stateFlags)) = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000E8F64 File Offset: 0x000E7164
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x0000FF34 File Offset: 0x0000E134
		public unsafe Object m_continuationObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_continuationObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x000E8F94 File Offset: 0x000E7194
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x0000FF53 File Offset: 0x0000E153
		public unsafe static Object s_taskCompletionSentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCompletionSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x000E8FBC File Offset: 0x000E71BC
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x0000FF65 File Offset: 0x0000E165
		public unsafe static bool s_asyncDebuggingEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_asyncDebuggingEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x000E8FD8 File Offset: 0x000E71D8
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x0000FF73 File Offset: 0x0000E173
		public unsafe static Dictionary<int, Task> s_currentActiveTasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_currentActiveTasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002DE1 RID: 11745 RVA: 0x000E9000 File Offset: 0x000E7200
		// (set) Token: 0x06002DE2 RID: 11746 RVA: 0x0000FF85 File Offset: 0x0000E185
		public unsafe static Object s_activeTasksLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_activeTasksLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_activeTasksLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x000E9028 File Offset: 0x000E7228
		// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x0000FF97 File Offset: 0x0000E197
		public unsafe Task.ContingentProperties m_contingentProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_m_contingentProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000E9058 File Offset: 0x000E7258
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x0000FFB6 File Offset: 0x0000E1B6
		public unsafe static Action<Object> s_taskCancelCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_taskCancelCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000E9080 File Offset: 0x000E7280
		// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		public unsafe static Func<Task.ContingentProperties> s_createContingentProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_createContingentProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task.ContingentProperties>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_createContingentProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000E90A8 File Offset: 0x000E72A8
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x0000FFDA File Offset: 0x0000E1DA
		public unsafe static Task s_completedTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_completedTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_completedTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000E90D0 File Offset: 0x000E72D0
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		public unsafe static Predicate<Task> s_IsExceptionObservedByParentPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Task>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000E90F8 File Offset: 0x000E72F8
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x0000FFFE File Offset: 0x0000E1FE
		public unsafe static ContextCallback s_ecCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_ecCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_ecCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x000E9120 File Offset: 0x000E7320
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x00010010 File Offset: 0x0000E210
		public unsafe static Predicate<Object> s_IsTaskContinuationNullPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeFieldInfoPtr_t_currentTask;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeFieldInfoPtr_t_stackGuard;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeFieldInfoPtr_s_taskIdCounter;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeFieldInfoPtr_s_factory;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeFieldInfoPtr_m_taskId;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeFieldInfoPtr_m_stateObject;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeFieldInfoPtr_m_parent;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeFieldInfoPtr_m_stateFlags;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeFieldInfoPtr_m_continuationObject;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCompletionSentinel;

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeFieldInfoPtr_s_asyncDebuggingEnabled;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeFieldInfoPtr_s_currentActiveTasks;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTasksLock;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeFieldInfoPtr_m_contingentProperties;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_s_taskCancelCallback;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_s_createContingentProperties;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_s_completedTask;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_s_IsExceptionObservedByParentPredicate;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_s_ecCallback;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeFieldInfoPtr_s_IsTaskContinuationNullPredicate;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTasks_Internal_Static_Boolean_Task_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromActiveTasks_Internal_Static_Void_Int32_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TaskCreationOptions_CancellationToken_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_Boolean_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_TaskConstructorCore_Internal_Void_Object_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_AssignCancellationToken_Private_Void_CancellationToken_Task_TaskContinuation_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_TaskCancelCallback_Private_Static_Void_Object_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr_PossiblyCaptureContext_Internal_Void_byref_StackCrawlMark_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Internal_get_TaskCreationOptions_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_OptionsMethod_Internal_Static_TaskCreationOptions_Int32_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_0;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr_AtomicStateUpdate_Internal_Boolean_Int32_Int32_byref_Int32_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationForWaitCompletion_Internal_Void_Boolean_0;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletionIfNecessary_Internal_Boolean_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabledOrNotRanToCompletion_Internal_get_Boolean_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldNotifyDebuggerOfWaitCompletion_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitNotificationEnabled_Internal_get_Boolean_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDebuggerOfWaitCompletion_Private_Void_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr_MarkStarted_Internal_Boolean_0;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_FireTaskScheduledIfNeeded_Internal_Boolean_TaskScheduler_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_AddNewChild_Internal_Void_0;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeMethodInfoPtr_DisregardChild_Internal_Void_0;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeMethodInfoPtr_InternalStartNew_Internal_Static_Task_Task_Delegate_Object_CancellationToken_TaskScheduler_TaskCreationOptions_InternalTaskOptions_byref_StackCrawlMark_0;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr_NewId_Internal_Static_Int32_0;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_Task_0;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeMethodInfoPtr_InternalCurrentIfAttached_Internal_Static_Task_TaskCreationOptions_0;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStackGuard_Internal_Static_get_StackGuard_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_AggregateException_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_TaskStatus_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCanceled_Public_get_Boolean_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationRequested_Internal_get_Boolean_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitialized_Internal_ContingentProperties_Boolean_0;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeMethodInfoPtr_EnsureContingentPropertiesInitializedCore_Private_ContingentProperties_Boolean_0;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Internal_get_CancellationToken_0;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCancellationAcknowledged_Internal_get_Boolean_0;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeMethodInfoPtr_IsCompletedMethod_Private_Static_Boolean_Int32_0;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRanToCompletion_Internal_get_Boolean_0;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeMethodInfoPtr_get_CreationOptions_Public_get_TaskCreationOptions_0;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingTaskScheduler_Internal_get_TaskScheduler_0;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_0;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedTask_Public_Static_get_Task_0;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedEvent_Internal_get_ManualResetEventSlim_0;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelfReplicatingRoot_Internal_get_Boolean_0;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChildReplica_Internal_get_Boolean_0;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionRecorded_Internal_get_Boolean_0;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaulted_Public_get_Boolean_0;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeMethodInfoPtr_get_CapturedContext_Internal_get_ExecutionContext_0;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeMethodInfoPtr_set_CapturedContext_Internal_set_Void_ExecutionContext_0;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_CopyExecutionContext_Private_Static_ExecutionContext_ExecutionContext_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleAndStart_Internal_Void_Boolean_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_AddException_Internal_Void_Object_Boolean_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptions_Private_AggregateException_Boolean_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfExceptional_Internal_Void_Boolean_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExceptionObservedStatus_Internal_Void_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExceptionObservedByParent_Internal_get_Boolean_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDelegateInvoked_Internal_get_Boolean_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_Boolean_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageTwo_Internal_Void_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_FinishStageThree_Internal_Void_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_ProcessChildCompletion_Internal_Void_Task_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_AddExceptionsFromChildren_Internal_Void_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr_FinishThreadAbortedTask_Internal_Void_Boolean_Boolean_0;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeMethodInfoPtr_ShouldReplicate_Internal_Virtual_New_Boolean_0;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr_CreateReplicaTask_Internal_Virtual_New_Task_Action_1_Object_Object_Task_TaskScheduler_TaskCreationOptions_InternalTaskOptions_0;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeMethodInfoPtr_get_SavedStateForNextReplica_Internal_Virtual_New_get_Object_0;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeMethodInfoPtr_set_SavedStateFromPreviousReplica_Internal_Virtual_New_set_Void_Object_0;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeMethodInfoPtr_get_HandedOverChildReplica_Internal_Virtual_New_get_Task_0;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeMethodInfoPtr_set_HandedOverChildReplica_Internal_Virtual_New_set_Void_Task_0;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteSelfReplicating_Private_Static_Void_Task_0;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEntry_Internal_Boolean_Boolean_0;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWithThreadLocal_Private_Void_byref_Task_0;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeMethodInfoPtr_ExecutionContextCallback_Private_Static_Void_Object_0;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_New_Void_0;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvokeWithArg_Internal_Void_Task_0;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeMethodInfoPtr_HandleException_Private_Void_Exception_0;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_0;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_Boolean_0;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeMethodInfoPtr_SetContinuationForAwait_Internal_Void_Action_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeMethodInfoPtr_WrappedTryRunInline_Private_Boolean_0;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeMethodInfoPtr_InternalWait_Internal_Boolean_Int32_CancellationToken_0;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_SpinThenBlockingWait_Private_Boolean_Int32_CancellationToken_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Private_Boolean_Int32_0;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr_InternalCancel_Internal_Boolean_Boolean_0;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_0;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_0;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeMethodInfoPtr_RecordInternalCancellationRequest_Internal_Void_CancellationToken_Object_0;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeMethodInfoPtr_CancellationCleanupLogic_Internal_Void_0;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationAcknowledged_Private_Void_0;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeMethodInfoPtr_FinishContinuations_Internal_Void_0;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeMethodInfoPtr_LogFinishCompletionNotification_Private_Void_0;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_1_Task_0;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_1_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_Action_2_Task_Object_Object_CancellationToken_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Private_Task_Action_2_Task_Object_Object_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_CreationOptionsFromContinuationOptions_Internal_Static_Void_TaskContinuationOptions_byref_TaskCreationOptions_byref_InternalTaskOptions_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWithCore_Internal_Void_Task_TaskScheduler_CancellationToken_TaskContinuationOptions_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Internal_Void_ITaskCompletionAction_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_AddCompletionAction_Private_Void_ITaskCompletionAction_Boolean_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuationComplex_Private_Boolean_Object_Boolean_0;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_AddTaskContinuation_Private_Boolean_Object_Boolean_0;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContinuation_Internal_Void_Object_0;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_Exception_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_CancellationToken_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_Action_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Task_Int32_CancellationToken_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_Il2CppReferenceArray_1_Task_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr_WhenAny_Public_Static_Task_1_Task_IEnumerable_1_Task_0;

		// Token: 0x02000604 RID: 1540
		public class ContingentProperties : Object
		{
			// Token: 0x060052FB RID: 21243 RVA: 0x001718B4 File Offset: 0x0016FAB4
			// Note: this type is marked as 'beforefieldinit'.
			static ContingentProperties()
			{
				Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "ContingentProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr);
				Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_capturedContext");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionEvent");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionsHolder");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationToken");
				Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_cancellationRegistration");
				Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_internalCancellationRequested");
				Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_completionCountdown");
				Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, "m_exceptionalChildren");
				Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670579);
				Task.ContingentProperties.NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670580);
				Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr, 100670581);
			}

			// Token: 0x060052FC RID: 21244 RVA: 0x001719BC File Offset: 0x0016FBBC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 334406, RefRangeEnd = 334409, XrefRangeStart = 334404, XrefRangeEnd = 334406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetCompleted()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_SetCompleted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FD RID: 21245 RVA: 0x001719F0 File Offset: 0x0016FBF0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334411, RefRangeEnd = 334413, XrefRangeStart = 334409, XrefRangeEnd = 334411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DeregisterCancellationCallback()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FE RID: 21246 RVA: 0x00171A24 File Offset: 0x0016FC24
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 334415, RefRangeEnd = 334420, XrefRangeStart = 334413, XrefRangeEnd = 334415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContingentProperties()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.ContingentProperties>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.ContingentProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FF RID: 21247 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
			public ContingentProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700152F RID: 5423
			// (get) Token: 0x06005300 RID: 21248 RVA: 0x00171A60 File Offset: 0x0016FC60
			// (set) Token: 0x06005301 RID: 21249 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
			public unsafe ExecutionContext m_capturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001530 RID: 5424
			// (get) Token: 0x06005302 RID: 21250 RVA: 0x00171A90 File Offset: 0x0016FC90
			// (set) Token: 0x06005303 RID: 21251 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
			public unsafe ManualResetEventSlim m_completionEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEventSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001531 RID: 5425
			// (get) Token: 0x06005304 RID: 21252 RVA: 0x00171AC0 File Offset: 0x0016FCC0
			// (set) Token: 0x06005305 RID: 21253 RVA: 0x0001FC0F File Offset: 0x0001DE0F
			public unsafe TaskExceptionHolder m_exceptionsHolder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskExceptionHolder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionsHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001532 RID: 5426
			// (get) Token: 0x06005306 RID: 21254 RVA: 0x00171AF0 File Offset: 0x0016FCF0
			// (set) Token: 0x06005307 RID: 21255 RVA: 0x0001FC2E File Offset: 0x0001DE2E
			public CancellationToken m_cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001533 RID: 5427
			// (get) Token: 0x06005308 RID: 21256 RVA: 0x00171B20 File Offset: 0x0016FD20
			// (set) Token: 0x06005309 RID: 21257 RVA: 0x0001FC5C File Offset: 0x0001DE5C
			public unsafe Shared<CancellationTokenRegistration> m_cancellationRegistration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shared<CancellationTokenRegistration>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_cancellationRegistration), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001534 RID: 5428
			// (get) Token: 0x0600530A RID: 21258 RVA: 0x00171B50 File Offset: 0x0016FD50
			// (set) Token: 0x0600530B RID: 21259 RVA: 0x0001FC7B File Offset: 0x0001DE7B
			public unsafe int m_internalCancellationRequested
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_internalCancellationRequested)) = value;
				}
			}

			// Token: 0x17001535 RID: 5429
			// (get) Token: 0x0600530C RID: 21260 RVA: 0x00171B78 File Offset: 0x0016FD78
			// (set) Token: 0x0600530D RID: 21261 RVA: 0x0001FC96 File Offset: 0x0001DE96
			public unsafe int m_completionCountdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_completionCountdown)) = value;
				}
			}

			// Token: 0x17001536 RID: 5430
			// (get) Token: 0x0600530E RID: 21262 RVA: 0x00171BA0 File Offset: 0x0016FDA0
			// (set) Token: 0x0600530F RID: 21263 RVA: 0x0001FCB1 File Offset: 0x0001DEB1
			public unsafe List<Task> m_exceptionalChildren
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.ContingentProperties.NativeFieldInfoPtr_m_exceptionalChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004328 RID: 17192
			private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

			// Token: 0x04004329 RID: 17193
			private static readonly IntPtr NativeFieldInfoPtr_m_completionEvent;

			// Token: 0x0400432A RID: 17194
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionsHolder;

			// Token: 0x0400432B RID: 17195
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationToken;

			// Token: 0x0400432C RID: 17196
			private static readonly IntPtr NativeFieldInfoPtr_m_cancellationRegistration;

			// Token: 0x0400432D RID: 17197
			private static readonly IntPtr NativeFieldInfoPtr_m_internalCancellationRequested;

			// Token: 0x0400432E RID: 17198
			private static readonly IntPtr NativeFieldInfoPtr_m_completionCountdown;

			// Token: 0x0400432F RID: 17199
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionalChildren;

			// Token: 0x04004330 RID: 17200
			private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Internal_Void_0;

			// Token: 0x04004331 RID: 17201
			private static readonly IntPtr NativeMethodInfoPtr_DeregisterCancellationCallback_Internal_Void_0;

			// Token: 0x04004332 RID: 17202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000605 RID: 1541
		public sealed class SetOnInvokeMres : ManualResetEventSlim
		{
			// Token: 0x06005310 RID: 21264 RVA: 0x00171BD0 File Offset: 0x0016FDD0
			// Note: this type is marked as 'beforefieldinit'.
			static SetOnInvokeMres()
			{
				Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "SetOnInvokeMres");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr);
				Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100670582);
				Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr, 100670583);
			}

			// Token: 0x06005311 RID: 21265 RVA: 0x00171C24 File Offset: 0x0016FE24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334424, RefRangeEnd = 334425, XrefRangeStart = 334420, XrefRangeEnd = 334424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetOnInvokeMres()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.SetOnInvokeMres>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005312 RID: 21266 RVA: 0x00171C60 File Offset: 0x0016FE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334425, XrefRangeEnd = 334426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.SetOnInvokeMres.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005313 RID: 21267 RVA: 0x0001FCD0 File Offset: 0x0001DED0
			public SetOnInvokeMres(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004333 RID: 17203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004334 RID: 17204
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x02000606 RID: 1542
		public sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x06005314 RID: 21268 RVA: 0x00171CA4 File Offset: 0x0016FEA4
			// Note: this type is marked as 'beforefieldinit'.
			static DelayPromise()
			{
				Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "DelayPromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr);
				Task.DelayPromise.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Token");
				Task.DelayPromise.NativeFieldInfoPtr_Registration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Registration");
				Task.DelayPromise.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, "Timer");
				Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100670584);
				Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr, 100670585);
			}

			// Token: 0x06005315 RID: 21269 RVA: 0x00171D34 File Offset: 0x0016FF34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334443, RefRangeEnd = 334444, XrefRangeStart = 334426, XrefRangeEnd = 334443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelayPromise(CancellationToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.DelayPromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005316 RID: 21270 RVA: 0x00171D84 File Offset: 0x0016FF84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 334465, RefRangeEnd = 334467, XrefRangeStart = 334444, XrefRangeEnd = 334465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.DelayPromise.NativeMethodInfoPtr_Complete_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005317 RID: 21271 RVA: 0x0001FCD9 File Offset: 0x0001DED9
			public DelayPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001537 RID: 5431
			// (get) Token: 0x06005318 RID: 21272 RVA: 0x00171DB8 File Offset: 0x0016FFB8
			// (set) Token: 0x06005319 RID: 21273 RVA: 0x0001FCE2 File Offset: 0x0001DEE2
			public CancellationToken Token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Token), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001538 RID: 5432
			// (get) Token: 0x0600531A RID: 21274 RVA: 0x00171DE8 File Offset: 0x0016FFE8
			// (set) Token: 0x0600531B RID: 21275 RVA: 0x0001FD10 File Offset: 0x0001DF10
			public CancellationTokenRegistration Registration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration);
					return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Registration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001539 RID: 5433
			// (get) Token: 0x0600531C RID: 21276 RVA: 0x00171E18 File Offset: 0x00170018
			// (set) Token: 0x0600531D RID: 21277 RVA: 0x0001FD3E File Offset: 0x0001DF3E
			public unsafe Timer Timer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.DelayPromise.NativeFieldInfoPtr_Timer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004335 RID: 17205
			private static readonly IntPtr NativeFieldInfoPtr_Token;

			// Token: 0x04004336 RID: 17206
			private static readonly IntPtr NativeFieldInfoPtr_Registration;

			// Token: 0x04004337 RID: 17207
			private static readonly IntPtr NativeFieldInfoPtr_Timer;

			// Token: 0x04004338 RID: 17208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CancellationToken_0;

			// Token: 0x04004339 RID: 17209
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_0;
		}

		// Token: 0x02000607 RID: 1543
		[ObfuscatedName("System.Threading.Tasks.Task+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Object
		{
			// Token: 0x0600531E RID: 21278 RVA: 0x00171E48 File Offset: 0x00170048
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr);
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "root");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "replicasAreQuitting");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "taskReplicaDelegate");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "creationOptionsForReplicas");
				Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, "internalOptionsForReplicas");
				Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, 100670586);
				Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr, 100670587);
			}

			// Token: 0x0600531F RID: 21279 RVA: 0x00171F00 File Offset: 0x00170100
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.__c__DisplayClass178_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005320 RID: 21280 RVA: 0x00171F3C File Offset: 0x0017013C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334467, XrefRangeEnd = 334493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteSelfReplicating_b__0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c__DisplayClass178_0.NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005321 RID: 21281 RVA: 0x0001FD5D File Offset: 0x0001DF5D
			public __c__DisplayClass178_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700153A RID: 5434
			// (get) Token: 0x06005322 RID: 21282 RVA: 0x00171F80 File Offset: 0x00170180
			// (set) Token: 0x06005323 RID: 21283 RVA: 0x0001FD66 File Offset: 0x0001DF66
			public unsafe Task root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700153B RID: 5435
			// (get) Token: 0x06005324 RID: 21284 RVA: 0x00171FB0 File Offset: 0x001701B0
			// (set) Token: 0x06005325 RID: 21285 RVA: 0x0001FD85 File Offset: 0x0001DF85
			public unsafe bool replicasAreQuitting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_replicasAreQuitting)) = value;
				}
			}

			// Token: 0x1700153C RID: 5436
			// (get) Token: 0x06005326 RID: 21286 RVA: 0x00171FD8 File Offset: 0x001701D8
			// (set) Token: 0x06005327 RID: 21287 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
			public unsafe Action<Object> taskReplicaDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_taskReplicaDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700153D RID: 5437
			// (get) Token: 0x06005328 RID: 21288 RVA: 0x00172008 File Offset: 0x00170208
			// (set) Token: 0x06005329 RID: 21289 RVA: 0x0001FDBF File Offset: 0x0001DFBF
			public unsafe TaskCreationOptions creationOptionsForReplicas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_creationOptionsForReplicas)) = value;
				}
			}

			// Token: 0x1700153E RID: 5438
			// (get) Token: 0x0600532A RID: 21290 RVA: 0x00172030 File Offset: 0x00170230
			// (set) Token: 0x0600532B RID: 21291 RVA: 0x0001FDDA File Offset: 0x0001DFDA
			public unsafe InternalTaskOptions internalOptionsForReplicas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.__c__DisplayClass178_0.NativeFieldInfoPtr_internalOptionsForReplicas)) = value;
				}
			}

			// Token: 0x0400433A RID: 17210
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400433B RID: 17211
			private static readonly IntPtr NativeFieldInfoPtr_replicasAreQuitting;

			// Token: 0x0400433C RID: 17212
			private static readonly IntPtr NativeFieldInfoPtr_taskReplicaDelegate;

			// Token: 0x0400433D RID: 17213
			private static readonly IntPtr NativeFieldInfoPtr_creationOptionsForReplicas;

			// Token: 0x0400433E RID: 17214
			private static readonly IntPtr NativeFieldInfoPtr_internalOptionsForReplicas;

			// Token: 0x0400433F RID: 17215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004340 RID: 17216
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteSelfReplicating_b__0_Internal_Void_Object_0;
		}

		// Token: 0x02000608 RID: 1544
		[ObfuscatedName("System.Threading.Tasks.Task+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600532C RID: 21292 RVA: 0x00172058 File Offset: 0x00170258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Task.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task.__c>.NativeClassPtr);
				Task.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9");
				Task.__c.NativeFieldInfoPtr___9__276_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__276_0");
				Task.__c.NativeFieldInfoPtr___9__276_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, "<>9__276_1");
				Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670589);
				Task.__c.NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670590);
				Task.__c.NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670591);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670592);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670593);
				Task.__c.NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task.__c>.NativeClassPtr, 100670594);
			}

			// Token: 0x0600532D RID: 21293 RVA: 0x00172138 File Offset: 0x00170338
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600532E RID: 21294 RVA: 0x00172174 File Offset: 0x00170374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334493, XrefRangeEnd = 334498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__276_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600532F RID: 21295 RVA: 0x001721B8 File Offset: 0x001703B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334498, XrefRangeEnd = 334503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Delay_b__276_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005330 RID: 21296 RVA: 0x001721FC File Offset: 0x001703FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334503, XrefRangeEnd = 334508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task.ContingentProperties __cctor_b__295_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task.ContingentProperties>(intPtr3) : null;
			}

			// Token: 0x06005331 RID: 21297 RVA: 0x0017223C File Offset: 0x0017043C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334508, XrefRangeEnd = 334510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__295_1(Task t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005332 RID: 21298 RVA: 0x0017228C File Offset: 0x0017048C
			[CallerCount(0)]
			public unsafe bool __cctor_b__295_2(Object tc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.__c.NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005333 RID: 21299 RVA: 0x0001FDF5 File Offset: 0x0001DFF5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700153F RID: 5439
			// (get) Token: 0x06005334 RID: 21300 RVA: 0x001722DC File Offset: 0x001704DC
			// (set) Token: 0x06005335 RID: 21301 RVA: 0x0001FDFE File Offset: 0x0001DFFE
			public unsafe static Task.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001540 RID: 5440
			// (get) Token: 0x06005336 RID: 21302 RVA: 0x00172304 File Offset: 0x00170504
			// (set) Token: 0x06005337 RID: 21303 RVA: 0x0001FE10 File Offset: 0x0001E010
			public unsafe static Action<Object> __9__276_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__276_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__276_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001541 RID: 5441
			// (get) Token: 0x06005338 RID: 21304 RVA: 0x0017232C File Offset: 0x0017052C
			// (set) Token: 0x06005339 RID: 21305 RVA: 0x0001FE22 File Offset: 0x0001E022
			public unsafe static TimerCallback __9__276_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task.__c.NativeFieldInfoPtr___9__276_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task.__c.NativeFieldInfoPtr___9__276_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004341 RID: 17217
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004342 RID: 17218
			private static readonly IntPtr NativeFieldInfoPtr___9__276_0;

			// Token: 0x04004343 RID: 17219
			private static readonly IntPtr NativeFieldInfoPtr___9__276_1;

			// Token: 0x04004344 RID: 17220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004345 RID: 17221
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__276_0_Internal_Void_Object_0;

			// Token: 0x04004346 RID: 17222
			private static readonly IntPtr NativeMethodInfoPtr__Delay_b__276_1_Internal_Void_Object_0;

			// Token: 0x04004347 RID: 17223
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_0_Internal_ContingentProperties_0;

			// Token: 0x04004348 RID: 17224
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_1_Internal_Boolean_Task_0;

			// Token: 0x04004349 RID: 17225
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__295_2_Internal_Boolean_Object_0;
		}

		// Token: 0x02000609 RID: 1545
		private sealed class MethodInfoStoreGeneric_FromResult_Public_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x0400434A RID: 17226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromResult_Public_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060A RID: 1546
		private sealed class MethodInfoStoreGeneric_FromException_Public_Static_Task_1_TResult_Exception_0<TResult>
		{
			// Token: 0x0400434B RID: 17227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromException_Public_Static_Task_1_TResult_Exception_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060B RID: 1547
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x0400434C RID: 17228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060C RID: 1548
		private sealed class MethodInfoStoreGeneric_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0<TResult>
		{
			// Token: 0x0400434D RID: 17229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_FromCancellation_Internal_Static_Task_1_TResult_OperationCanceledException_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060D RID: 1549
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_TResult_0<TResult>
		{
			// Token: 0x0400434E RID: 17230
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060E RID: 1550
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0<TResult>
		{
			// Token: 0x0400434F RID: 17231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200060F RID: 1551
		private sealed class MethodInfoStoreGeneric_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0<TResult>
		{
			// Token: 0x04004350 RID: 17232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task.NativeMethodInfoPtr_Run_Public_Static_Task_1_TResult_Func_1_Task_1_TResult_CancellationToken_0, Il2CppClassPointerStore<Task>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
